using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace PrjGeradorSenha
{
    public partial class FrmGeradorSenhas : Form
    {
        public FrmGeradorSenhas()
        {
            InitializeComponent();

            // Inicialmente só habilita as caixas de tamanho quando o respectivo checkbox for marcado
            txtTamanho.Enabled = false;
            txtAleatorioTamanho.Enabled = false;
        }

        // ===== VALIDAÇÕES DE CONFLITO ENTRE CHECKBOXES =====

        private void chkTamanho_CheckedChanged(object sender, EventArgs e)
        {
            // Tamanho fixo e aleatório são mutuamente exclusivos
            if (chkTamanho.Checked) chkAleatorioTamanho.Checked = false;
            txtTamanho.Enabled = chkTamanho.Checked;
        }

        private void chkAleatorioTamanho_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAleatorioTamanho.Checked) chkTamanho.Checked = false;
            txtAleatorioTamanho.Enabled = chkAleatorioTamanho.Checked;
        }

        private void chkGUID_CheckedChanged(object sender, EventArgs e)
        {
            if (chkGUID.Checked)
            {
                // Desmarca e desabilita tudo o que não se aplica
                chkTamanho.Checked = chkAleatorioTamanho.Checked = false;
                txtTamanho.Enabled = txtAleatorioTamanho.Enabled = false;

                chkCripto.Checked = false;
                chkCripto.Enabled = false;

                chkMaiuscula.Checked = false;
                chkMaiuscula.Enabled = false;

                // GUID gera em minúsculas
                chkMinuscula.Checked = true;
                chkMinuscula.Enabled = false;

                chkSimbolos.Checked = false;
                chkSimbolos.Enabled = false;

                chkSomenteNumeros.Checked = false;
                chkSomenteNumeros.Enabled = false;
            }
            else
            {
                // Reabilita todas as outras opções
                chkTamanho.Enabled = chkAleatorioTamanho.Enabled = true;
                chkCripto.Enabled = true;
                chkMaiuscula.Enabled = true;
                chkMinuscula.Enabled = true;
                chkSimbolos.Enabled = true;
                chkSomenteNumeros.Enabled = true;
            }
        }

        private void chkCripto_CheckedChanged(object sender, EventArgs e)
        {
            // Criptografia não combina com GUID
            if (chkCripto.Checked && chkGUID.Checked)
                chkCripto.Checked = false;
        }

        private void chkSomenteNumeros_CheckedChanged(object sender, EventArgs e)
        {
            // Agora 'Somente Números' só adiciona dígitos ao pool.
            // Não desabilita mais outros checkboxes — a combinação é permitida.
        }

        private void chkMaiuscula_CheckedChanged(object sender, EventArgs e)
        {
            // Se marcar maiúsculas enquanto GUID ativo, desmarca GUID
            if (chkMaiuscula.Checked && chkGUID.Checked)
                chkGUID.Checked = false;
        }

        private void chkMinuscula_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMinuscula.Checked && chkGUID.Checked)
                chkGUID.Checked = false;
        }

        private void chkSimbolos_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSimbolos.Checked && chkGUID.Checked)
                chkGUID.Checked = false;
        }

        // ===== BOTÃO GERAR =====

        private void btnGerar_Click(object sender, EventArgs e)
        {
            // 1) GUID tem prioridade
            if (chkGUID.Checked)
            {
                txtSenhaGerada.Text = Guid.NewGuid().ToString();
                return;
            }

            // 2) Define o comprimento
            int length;
            if (chkTamanho.Checked)
            {
                if (!int.TryParse(txtTamanho.Text, out length) || length <= 0)
                {
                    MessageBox.Show("Informe um tamanho válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else if (chkAleatorioTamanho.Checked)
            {
                if (!int.TryParse(txtAleatorioTamanho.Text, out length) || length <= 0)
                {
                    MessageBox.Show("Informe um tamanho válido para senha aleatória.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Marque uma das opções de tamanho.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 3) Gera a senha
            txtSenhaGerada.Text = GeneratePassword(length);
        }

        // ===== GERAÇÃO DE SENHA =====

        private string GeneratePassword(int length)
        {
            const string UPPER = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string LOWER = "abcdefghijklmnopqrstuvwxyz";
            const string DIGITS = "0123456789";
            const string SYMBOLS = "!\"#$%&'()*+,-./:;<=>?@[\\]^_`{|}~";

            // Monta categorias:
            // - inclua maiúsculas se chkMaiuscula
            // - inclua minúsculas se chkMinuscula
            // - inclua símbolos se chkSimbolos
            // - inclua dígitos se chkSomenteNumeros
            var categories = new List<string>();
            if (chkMaiuscula.Checked) categories.Add(UPPER);
            if (chkMinuscula.Checked) categories.Add(LOWER);
            if (chkSimbolos.Checked) categories.Add(SYMBOLS);
            if (chkSomenteNumeros.Checked) categories.Add(DIGITS);

            if (categories.Count == 0)
            {
                MessageBox.Show(
                    "Selecione ao menos uma categoria: Maiúsculas, Minúsculas, Símbolos ou Números.",
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return string.Empty;
            }

            // Concatena todas as categorias para formar o pool de caracteres
            string allChars = string.Concat(categories);

            // Preparação de geradores
            var rnd = new Random();
            RandomNumberGenerator rngCrypto = chkCripto.Checked
                ? RandomNumberGenerator.Create()
                : null;

            char NextChar(string set)
            {
                if (rngCrypto != null)
                {
                    var buf = new byte[4];
                    rngCrypto.GetBytes(buf);
                    uint val = BitConverter.ToUInt32(buf, 0);
                    return set[(int)(val % set.Length)];
                }
                else
                {
                    return set[rnd.Next(set.Length)];
                }
            }

            // Garante pelo menos um de cada categoria marcada
            var pwd = new List<char>();
            foreach (var cat in categories)
                pwd.Add(NextChar(cat));

            // Preenche até atingir o tamanho desejado
            for (int i = pwd.Count; i < length; i++)
                pwd.Add(NextChar(allChars));

            // Embaralha a lista final
            for (int i = 0; i < pwd.Count; i++)
            {
                int j = rnd.Next(pwd.Count);
                var tmp = pwd[i];
                pwd[i] = pwd[j];
                pwd[j] = tmp;
            }

            rngCrypto?.Dispose();
            return new string(pwd.ToArray());
        }

        // ===== COPIAR & SAIR =====

        private void btnCopiarSenha_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSenhaGerada.Text))
                Clipboard.SetText(txtSenhaGerada.Text);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}


namespace PrjGeradorSenha
{
    partial class FrmGeradorSenhas
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGeradorSenhas));
            this.chkTamanho = new System.Windows.Forms.CheckBox();
            this.chkCripto = new System.Windows.Forms.CheckBox();
            this.chkGUID = new System.Windows.Forms.CheckBox();
            this.chkAleatorioTamanho = new System.Windows.Forms.CheckBox();
            this.chkMaiuscula = new System.Windows.Forms.CheckBox();
            this.chkMinuscula = new System.Windows.Forms.CheckBox();
            this.chkSomenteNumeros = new System.Windows.Forms.CheckBox();
            this.txtSenhaGerada = new System.Windows.Forms.TextBox();
            this.btnGerar = new System.Windows.Forms.Button();
            this.btnCopiarSenha = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.chkSimbolos = new System.Windows.Forms.CheckBox();
            this.txtTamanho = new System.Windows.Forms.TextBox();
            this.txtAleatorioTamanho = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // chkTamanho
            // 
            this.chkTamanho.AutoSize = true;
            this.chkTamanho.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkTamanho.Location = new System.Drawing.Point(12, 12);
            this.chkTamanho.Name = "chkTamanho";
            this.chkTamanho.Size = new System.Drawing.Size(287, 32);
            this.chkTamanho.TabIndex = 0;
            this.chkTamanho.Text = "Gerar com Tamanho definido";
            this.chkTamanho.UseVisualStyleBackColor = true;
            this.chkTamanho.CheckedChanged += new System.EventHandler(this.chkTamanho_CheckedChanged);
            // 
            // chkCripto
            // 
            this.chkCripto.AutoSize = true;
            this.chkCripto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkCripto.Location = new System.Drawing.Point(12, 42);
            this.chkCripto.Name = "chkCripto";
            this.chkCripto.Size = new System.Drawing.Size(236, 32);
            this.chkCripto.TabIndex = 1;
            this.chkCripto.Text = "Sistema de criptografia";
            this.chkCripto.UseVisualStyleBackColor = true;
            this.chkCripto.CheckedChanged += new System.EventHandler(this.chkCripto_CheckedChanged);
            // 
            // chkGUID
            // 
            this.chkGUID.AutoSize = true;
            this.chkGUID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkGUID.Location = new System.Drawing.Point(12, 72);
            this.chkGUID.Name = "chkGUID";
            this.chkGUID.Size = new System.Drawing.Size(153, 32);
            this.chkGUID.TabIndex = 2;
            this.chkGUID.Text = "Usando GUID";
            this.chkGUID.UseVisualStyleBackColor = true;
            this.chkGUID.CheckedChanged += new System.EventHandler(this.chkGUID_CheckedChanged);
            // 
            // chkAleatorioTamanho
            // 
            this.chkAleatorioTamanho.AutoSize = true;
            this.chkAleatorioTamanho.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkAleatorioTamanho.Location = new System.Drawing.Point(12, 102);
            this.chkAleatorioTamanho.Name = "chkAleatorioTamanho";
            this.chkAleatorioTamanho.Size = new System.Drawing.Size(372, 32);
            this.chkAleatorioTamanho.TabIndex = 3;
            this.chkAleatorioTamanho.Text = "Senha aleatória com tamanho definido";
            this.chkAleatorioTamanho.UseVisualStyleBackColor = true;
            this.chkAleatorioTamanho.CheckedChanged += new System.EventHandler(this.chkAleatorioTamanho_CheckedChanged);
            // 
            // chkMaiuscula
            // 
            this.chkMaiuscula.AutoSize = true;
            this.chkMaiuscula.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkMaiuscula.Location = new System.Drawing.Point(471, 12);
            this.chkMaiuscula.Name = "chkMaiuscula";
            this.chkMaiuscula.Size = new System.Drawing.Size(184, 32);
            this.chkMaiuscula.TabIndex = 4;
            this.chkMaiuscula.Text = "Letras maiúsculas";
            this.chkMaiuscula.UseVisualStyleBackColor = true;
            this.chkMaiuscula.CheckedChanged += new System.EventHandler(this.chkMaiuscula_CheckedChanged);
            // 
            // chkMinuscula
            // 
            this.chkMinuscula.AutoSize = true;
            this.chkMinuscula.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkMinuscula.Location = new System.Drawing.Point(471, 42);
            this.chkMinuscula.Name = "chkMinuscula";
            this.chkMinuscula.Size = new System.Drawing.Size(185, 32);
            this.chkMinuscula.TabIndex = 5;
            this.chkMinuscula.Text = "Letras minúsculas";
            this.chkMinuscula.UseVisualStyleBackColor = true;
            this.chkMinuscula.CheckedChanged += new System.EventHandler(this.chkMinuscula_CheckedChanged);
            // 
            // chkSomenteNumeros
            // 
            this.chkSomenteNumeros.AutoSize = true;
            this.chkSomenteNumeros.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkSomenteNumeros.Location = new System.Drawing.Point(471, 72);
            this.chkSomenteNumeros.Name = "chkSomenteNumeros";
            this.chkSomenteNumeros.Size = new System.Drawing.Size(197, 32);
            this.chkSomenteNumeros.TabIndex = 6;
            this.chkSomenteNumeros.Text = "Somente Números";
            this.chkSomenteNumeros.UseVisualStyleBackColor = true;
            this.chkSomenteNumeros.CheckedChanged += new System.EventHandler(this.chkSomenteNumeros_CheckedChanged);
            // 
            // txtSenhaGerada
            // 
            this.txtSenhaGerada.Enabled = false;
            this.txtSenhaGerada.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSenhaGerada.Location = new System.Drawing.Point(12, 189);
            this.txtSenhaGerada.Multiline = true;
            this.txtSenhaGerada.Name = "txtSenhaGerada";
            this.txtSenhaGerada.Size = new System.Drawing.Size(717, 120);
            this.txtSenhaGerada.TabIndex = 7;
            // 
            // btnGerar
            // 
            this.btnGerar.BackColor = System.Drawing.Color.LightGreen;
            this.btnGerar.FlatAppearance.BorderSize = 0;
            this.btnGerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGerar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGerar.ForeColor = System.Drawing.Color.White;
            this.btnGerar.Location = new System.Drawing.Point(12, 140);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(717, 43);
            this.btnGerar.TabIndex = 8;
            this.btnGerar.Text = "Gerar";
            this.btnGerar.UseVisualStyleBackColor = false;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // btnCopiarSenha
            // 
            this.btnCopiarSenha.BackColor = System.Drawing.Color.Salmon;
            this.btnCopiarSenha.FlatAppearance.BorderSize = 0;
            this.btnCopiarSenha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopiarSenha.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCopiarSenha.ForeColor = System.Drawing.Color.White;
            this.btnCopiarSenha.Location = new System.Drawing.Point(573, 328);
            this.btnCopiarSenha.Name = "btnCopiarSenha";
            this.btnCopiarSenha.Size = new System.Drawing.Size(156, 43);
            this.btnCopiarSenha.TabIndex = 9;
            this.btnCopiarSenha.Text = "Copiar Senha";
            this.btnCopiarSenha.UseVisualStyleBackColor = false;
            this.btnCopiarSenha.Click += new System.EventHandler(this.btnCopiarSenha_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Red;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Location = new System.Drawing.Point(12, 328);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(94, 43);
            this.btnSair.TabIndex = 10;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // chkSimbolos
            // 
            this.chkSimbolos.AutoSize = true;
            this.chkSimbolos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkSimbolos.Location = new System.Drawing.Point(471, 102);
            this.chkSimbolos.Name = "chkSimbolos";
            this.chkSimbolos.Size = new System.Drawing.Size(116, 32);
            this.chkSimbolos.TabIndex = 11;
            this.chkSimbolos.Text = "Símbolos";
            this.chkSimbolos.UseVisualStyleBackColor = true;
            this.chkSimbolos.CheckedChanged += new System.EventHandler(this.chkSimbolos_CheckedChanged);
            // 
            // txtTamanho
            // 
            this.txtTamanho.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTamanho.Location = new System.Drawing.Point(305, 10);
            this.txtTamanho.MaxLength = 2;
            this.txtTamanho.Name = "txtTamanho";
            this.txtTamanho.Size = new System.Drawing.Size(125, 34);
            this.txtTamanho.TabIndex = 12;
            // 
            // txtAleatorioTamanho
            // 
            this.txtAleatorioTamanho.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAleatorioTamanho.Location = new System.Drawing.Point(390, 100);
            this.txtAleatorioTamanho.MaxLength = 2;
            this.txtAleatorioTamanho.Name = "txtAleatorioTamanho";
            this.txtAleatorioTamanho.Size = new System.Drawing.Size(59, 34);
            this.txtAleatorioTamanho.TabIndex = 13;
            // 
            // FrmGeradorSenhas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 383);
            this.Controls.Add(this.txtAleatorioTamanho);
            this.Controls.Add(this.txtTamanho);
            this.Controls.Add(this.chkSimbolos);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnCopiarSenha);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.txtSenhaGerada);
            this.Controls.Add(this.chkSomenteNumeros);
            this.Controls.Add(this.chkMinuscula);
            this.Controls.Add(this.chkMaiuscula);
            this.Controls.Add(this.chkAleatorioTamanho);
            this.Controls.Add(this.chkGUID);
            this.Controls.Add(this.chkCripto);
            this.Controls.Add(this.chkTamanho);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmGeradorSenhas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerador de Senhas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkTamanho;
        private System.Windows.Forms.CheckBox chkCripto;
        private System.Windows.Forms.CheckBox chkGUID;
        private System.Windows.Forms.CheckBox chkAleatorioTamanho;
        private System.Windows.Forms.CheckBox chkMaiuscula;
        private System.Windows.Forms.CheckBox chkMinuscula;
        private System.Windows.Forms.CheckBox chkSomenteNumeros;
        private System.Windows.Forms.TextBox txtSenhaGerada;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.Button btnCopiarSenha;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.CheckBox chkSimbolos;
        private System.Windows.Forms.TextBox txtTamanho;
        private System.Windows.Forms.TextBox txtAleatorioTamanho;
    }
}


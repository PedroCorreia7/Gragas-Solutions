﻿namespace Gragas_Solution_2
{
    partial class telaRegistro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.botaoVoltar = new System.Windows.Forms.Button();
            this.textoNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textoSenha = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textConfirmarSenha = new System.Windows.Forms.TextBox();
            this.textoData = new System.Windows.Forms.DateTimePicker();
            this.botaoAdicionar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textoLogin = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // botaoVoltar
            // 
            this.botaoVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoVoltar.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoVoltar.Location = new System.Drawing.Point(12, 12);
            this.botaoVoltar.Name = "botaoVoltar";
            this.botaoVoltar.Size = new System.Drawing.Size(136, 36);
            this.botaoVoltar.TabIndex = 9;
            this.botaoVoltar.Text = "Voltar";
            this.botaoVoltar.UseVisualStyleBackColor = true;
            this.botaoVoltar.Click += new System.EventHandler(this.button1_Click);
            // 
            // textoNome
            // 
            this.textoNome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textoNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoNome.Location = new System.Drawing.Point(559, 219);
            this.textoNome.Multiline = true;
            this.textoNome.Name = "textoNome";
            this.textoNome.Size = new System.Drawing.Size(279, 29);
            this.textoNome.TabIndex = 10;
            this.textoNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textoNome.TextChanged += new System.EventHandler(this.textoAdicionar_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Unispace", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(444, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(291, 42);
            this.label2.TabIndex = 12;
            this.label2.Text = "Registre-se !";
            // 
            // textoSenha
            // 
            this.textoSenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textoSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoSenha.Location = new System.Drawing.Point(472, 401);
            this.textoSenha.Multiline = true;
            this.textoSenha.Name = "textoSenha";
            this.textoSenha.PasswordChar = '*';
            this.textoSenha.Size = new System.Drawing.Size(125, 29);
            this.textoSenha.TabIndex = 13;
            this.textoSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(382, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 29);
            this.label3.TabIndex = 14;
            this.label3.Text = "Data de Nascimento:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(386, 401);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 29);
            this.label4.TabIndex = 15;
            this.label4.Text = "Senha:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(387, 457);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(191, 29);
            this.label5.TabIndex = 16;
            this.label5.Text = "Confirme a Senha:";
            // 
            // textConfirmarSenha
            // 
            this.textConfirmarSenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textConfirmarSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textConfirmarSenha.Location = new System.Drawing.Point(578, 459);
            this.textConfirmarSenha.Multiline = true;
            this.textConfirmarSenha.Name = "textConfirmarSenha";
            this.textConfirmarSenha.PasswordChar = '*';
            this.textConfirmarSenha.Size = new System.Drawing.Size(125, 29);
            this.textConfirmarSenha.TabIndex = 17;
            this.textConfirmarSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textoData
            // 
            this.textoData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textoData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoData.Location = new System.Drawing.Point(590, 282);
            this.textoData.Name = "textoData";
            this.textoData.Size = new System.Drawing.Size(322, 26);
            this.textoData.TabIndex = 18;
            // 
            // botaoAdicionar
            // 
            this.botaoAdicionar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.botaoAdicionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoAdicionar.Location = new System.Drawing.Point(479, 546);
            this.botaoAdicionar.Name = "botaoAdicionar";
            this.botaoAdicionar.Size = new System.Drawing.Size(262, 69);
            this.botaoAdicionar.TabIndex = 19;
            this.botaoAdicionar.Text = "Registrar";
            this.botaoAdicionar.UseVisualStyleBackColor = true;
            this.botaoAdicionar.Click += new System.EventHandler(this.botaoRegistrar_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(382, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 29);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nome Completo:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(386, 344);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 29);
            this.label6.TabIndex = 21;
            this.label6.Text = "Login:";
            // 
            // textoLogin
            // 
            this.textoLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textoLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoLogin.Location = new System.Drawing.Point(451, 344);
            this.textoLogin.Multiline = true;
            this.textoLogin.Name = "textoLogin";
            this.textoLogin.Size = new System.Drawing.Size(279, 29);
            this.textoLogin.TabIndex = 22;
            this.textoLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // telaRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 648);
            this.Controls.Add(this.textoLogin);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.botaoAdicionar);
            this.Controls.Add(this.textoData);
            this.Controls.Add(this.textConfirmarSenha);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textoSenha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textoNome);
            this.Controls.Add(this.botaoVoltar);
            this.Name = "telaRegistro";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "telaRegistro";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.telaRegistro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botaoVoltar;
        private System.Windows.Forms.TextBox textoNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textoSenha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textConfirmarSenha;
        private System.Windows.Forms.DateTimePicker textoData;
        private System.Windows.Forms.Button botaoAdicionar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textoLogin;
    }
}
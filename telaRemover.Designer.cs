namespace Gragas_Solution_2
{
    partial class telaRemover
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
            this.listaRemover = new System.Windows.Forms.ListBox();
            this.botaoRemoverEstoque = new System.Windows.Forms.Button();
            this.textoQuantidade = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // botaoVoltar
            // 
            this.botaoVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoVoltar.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoVoltar.Location = new System.Drawing.Point(12, 12);
            this.botaoVoltar.Name = "botaoVoltar";
            this.botaoVoltar.Size = new System.Drawing.Size(136, 36);
            this.botaoVoltar.TabIndex = 14;
            this.botaoVoltar.Text = "Voltar";
            this.botaoVoltar.UseVisualStyleBackColor = true;
            this.botaoVoltar.Click += new System.EventHandler(this.button1_Click);
            // 
            // listaRemover
            // 
            this.listaRemover.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listaRemover.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaRemover.FormattingEnabled = true;
            this.listaRemover.ItemHeight = 24;
            this.listaRemover.Items.AddRange(new object[] {
            "Processadores",
            "Memorias Flash",
            "Cristais de Clock",
            "Display para IHM",
            "Soquetes de Processador",
            "Dissipador de Calor",
            "Fonte de Alimentação"});
            this.listaRemover.Location = new System.Drawing.Point(645, 107);
            this.listaRemover.Name = "listaRemover";
            this.listaRemover.Size = new System.Drawing.Size(227, 28);
            this.listaRemover.TabIndex = 13;
            // 
            // botaoRemoverEstoque
            // 
            this.botaoRemoverEstoque.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.botaoRemoverEstoque.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoRemoverEstoque.Font = new System.Drawing.Font("Unispace", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoRemoverEstoque.Location = new System.Drawing.Point(425, 370);
            this.botaoRemoverEstoque.Name = "botaoRemoverEstoque";
            this.botaoRemoverEstoque.Size = new System.Drawing.Size(317, 76);
            this.botaoRemoverEstoque.TabIndex = 12;
            this.botaoRemoverEstoque.Text = "Remover do Estoque";
            this.botaoRemoverEstoque.UseVisualStyleBackColor = true;
            this.botaoRemoverEstoque.Click += new System.EventHandler(this.botaoAdicionarEstoque_Click);
            // 
            // textoQuantidade
            // 
            this.textoQuantidade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textoQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoQuantidade.Location = new System.Drawing.Point(487, 278);
            this.textoQuantidade.Multiline = true;
            this.textoQuantidade.Name = "textoQuantidade";
            this.textoQuantidade.Size = new System.Drawing.Size(145, 28);
            this.textoQuantidade.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Unispace", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(279, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 35);
            this.label2.TabIndex = 10;
            this.label2.Text = "Quantidade:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Unispace", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(280, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 35);
            this.label1.TabIndex = 9;
            this.label1.Text = "Selecione o produto:";
            // 
            // telaRemover
            // 
            this.AcceptButton = this.botaoVoltar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1174, 650);
            this.Controls.Add(this.botaoVoltar);
            this.Controls.Add(this.listaRemover);
            this.Controls.Add(this.botaoRemoverEstoque);
            this.Controls.Add(this.textoQuantidade);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "telaRemover";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "telaRemover";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.telaRemover_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botaoVoltar;
        private System.Windows.Forms.ListBox listaRemover;
        private System.Windows.Forms.Button botaoRemoverEstoque;
        private System.Windows.Forms.TextBox textoQuantidade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
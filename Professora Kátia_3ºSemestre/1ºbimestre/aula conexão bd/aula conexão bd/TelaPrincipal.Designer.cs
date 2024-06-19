namespace aula_conexão_bd
{
    partial class TelaPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnProduto = new System.Windows.Forms.Button();
            this.pnlTela = new System.Windows.Forms.Panel();
            this.btncategoria = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btncategoria);
            this.panel1.Controls.Add(this.btnProduto);
            this.panel1.Location = new System.Drawing.Point(17, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(112, 442);
            this.panel1.TabIndex = 0;
            // 
            // btnProduto
            // 
            this.btnProduto.Location = new System.Drawing.Point(9, 10);
            this.btnProduto.Name = "btnProduto";
            this.btnProduto.Size = new System.Drawing.Size(93, 63);
            this.btnProduto.TabIndex = 0;
            this.btnProduto.Text = "Produto";
            this.btnProduto.UseVisualStyleBackColor = true;
            this.btnProduto.Click += new System.EventHandler(this.btnProduto_Click);
            // 
            // pnlTela
            // 
            this.pnlTela.Location = new System.Drawing.Point(141, 12);
            this.pnlTela.Name = "pnlTela";
            this.pnlTela.Size = new System.Drawing.Size(1077, 439);
            this.pnlTela.TabIndex = 1;
            // 
            // btncategoria
            // 
            this.btncategoria.Location = new System.Drawing.Point(9, 79);
            this.btncategoria.Name = "btncategoria";
            this.btncategoria.Size = new System.Drawing.Size(92, 63);
            this.btncategoria.TabIndex = 1;
            this.btncategoria.Text = "Categoria";
            this.btncategoria.UseVisualStyleBackColor = true;
            this.btncategoria.Click += new System.EventHandler(this.button1_Click);
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 465);
            this.Controls.Add(this.pnlTela);
            this.Controls.Add(this.panel1);
            this.Name = "TelaPrincipal";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnProduto;
        private System.Windows.Forms.Panel pnlTela;
        private System.Windows.Forms.Button btncategoria;
    }
}


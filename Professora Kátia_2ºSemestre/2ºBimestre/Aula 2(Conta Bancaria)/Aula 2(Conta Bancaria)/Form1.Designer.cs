namespace Aula_2_Conta_Bancaria_
{
    partial class Form1
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
            this.btnespecial = new System.Windows.Forms.Button();
            this.btnpoupanca = new System.Windows.Forms.Button();
            this.pnlTelas = new System.Windows.Forms.Panel();
            this.tbxnome = new System.Windows.Forms.TextBox();
            this.lbnome = new System.Windows.Forms.Label();
            this.lbnuco = new System.Windows.Forms.Label();
            this.lbsal = new System.Windows.Forms.Label();
            this.tbxnuco = new System.Windows.Forms.TextBox();
            this.tbxsal = new System.Windows.Forms.TextBox();
            this.btncadastrar = new System.Windows.Forms.Button();
            this.lbconfirma = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnlTelas.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnespecial);
            this.panel1.Controls.Add(this.btnpoupanca);
            this.panel1.Location = new System.Drawing.Point(8, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(103, 483);
            this.panel1.TabIndex = 0;
            // 
            // btnespecial
            // 
            this.btnespecial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnespecial.Location = new System.Drawing.Point(4, 136);
            this.btnespecial.Name = "btnespecial";
            this.btnespecial.Size = new System.Drawing.Size(91, 92);
            this.btnespecial.TabIndex = 1;
            this.btnespecial.Text = "Conta Especial";
            this.btnespecial.UseVisualStyleBackColor = true;
            this.btnespecial.Click += new System.EventHandler(this.btnespecial_Click);
            // 
            // btnpoupanca
            // 
            this.btnpoupanca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpoupanca.Location = new System.Drawing.Point(3, 13);
            this.btnpoupanca.Name = "btnpoupanca";
            this.btnpoupanca.Size = new System.Drawing.Size(92, 95);
            this.btnpoupanca.TabIndex = 0;
            this.btnpoupanca.Text = "Conta Poupança";
            this.btnpoupanca.UseVisualStyleBackColor = true;
            this.btnpoupanca.Click += new System.EventHandler(this.btnpoupanca_Click);
            // 
            // pnlTelas
            // 
            this.pnlTelas.Controls.Add(this.lbconfirma);
            this.pnlTelas.Controls.Add(this.btncadastrar);
            this.pnlTelas.Controls.Add(this.tbxsal);
            this.pnlTelas.Controls.Add(this.tbxnuco);
            this.pnlTelas.Controls.Add(this.lbsal);
            this.pnlTelas.Controls.Add(this.lbnuco);
            this.pnlTelas.Controls.Add(this.lbnome);
            this.pnlTelas.Controls.Add(this.tbxnome);
            this.pnlTelas.Location = new System.Drawing.Point(125, 7);
            this.pnlTelas.Name = "pnlTelas";
            this.pnlTelas.Size = new System.Drawing.Size(820, 484);
            this.pnlTelas.TabIndex = 1;
            // 
            // tbxnome
            // 
            this.tbxnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxnome.Location = new System.Drawing.Point(380, 70);
            this.tbxnome.Name = "tbxnome";
            this.tbxnome.Size = new System.Drawing.Size(311, 38);
            this.tbxnome.TabIndex = 0;
            this.tbxnome.TextChanged += new System.EventHandler(this.tbxnome_TextChanged);
            // 
            // lbnome
            // 
            this.lbnome.AutoSize = true;
            this.lbnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnome.Location = new System.Drawing.Point(37, 77);
            this.lbnome.Name = "lbnome";
            this.lbnome.Size = new System.Drawing.Size(209, 31);
            this.lbnome.TabIndex = 1;
            this.lbnome.Text = "Digite seu nome";
            // 
            // lbnuco
            // 
            this.lbnuco.AutoSize = true;
            this.lbnuco.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnuco.Location = new System.Drawing.Point(37, 167);
            this.lbnuco.Name = "lbnuco";
            this.lbnuco.Size = new System.Drawing.Size(337, 31);
            this.lbnuco.TabIndex = 2;
            this.lbnuco.Text = "Digite um numero de conta";
            // 
            // lbsal
            // 
            this.lbsal.AutoSize = true;
            this.lbsal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbsal.Location = new System.Drawing.Point(37, 249);
            this.lbsal.Name = "lbsal";
            this.lbsal.Size = new System.Drawing.Size(253, 31);
            this.lbsal.TabIndex = 3;
            this.lbsal.Text = "Digite o saldo inicial";
            // 
            // tbxnuco
            // 
            this.tbxnuco.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxnuco.Location = new System.Drawing.Point(380, 160);
            this.tbxnuco.Name = "tbxnuco";
            this.tbxnuco.Size = new System.Drawing.Size(311, 38);
            this.tbxnuco.TabIndex = 4;
            // 
            // tbxsal
            // 
            this.tbxsal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxsal.Location = new System.Drawing.Point(380, 242);
            this.tbxsal.Name = "tbxsal";
            this.tbxsal.Size = new System.Drawing.Size(311, 38);
            this.tbxsal.TabIndex = 5;
            // 
            // btncadastrar
            // 
            this.btncadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncadastrar.Location = new System.Drawing.Point(310, 344);
            this.btncadastrar.Name = "btncadastrar";
            this.btncadastrar.Size = new System.Drawing.Size(170, 53);
            this.btncadastrar.TabIndex = 6;
            this.btncadastrar.Text = "cadastrar";
            this.btncadastrar.UseVisualStyleBackColor = true;
            this.btncadastrar.Click += new System.EventHandler(this.btncadastrar_Click);
            // 
            // lbconfirma
            // 
            this.lbconfirma.AutoSize = true;
            this.lbconfirma.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbconfirma.Location = new System.Drawing.Point(209, 303);
            this.lbconfirma.Name = "lbconfirma";
            this.lbconfirma.Size = new System.Drawing.Size(0, 31);
            this.lbconfirma.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 503);
            this.Controls.Add(this.pnlTelas);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.pnlTelas.ResumeLayout(false);
            this.pnlTelas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnespecial;
        private System.Windows.Forms.Button btnpoupanca;
        private System.Windows.Forms.Panel pnlTelas;
        private System.Windows.Forms.TextBox tbxnome;
        private System.Windows.Forms.TextBox tbxsal;
        private System.Windows.Forms.TextBox tbxnuco;
        private System.Windows.Forms.Label lbsal;
        private System.Windows.Forms.Label lbnuco;
        private System.Windows.Forms.Label lbnome;
        private System.Windows.Forms.Button btncadastrar;
        private System.Windows.Forms.Label lbconfirma;
    }
}


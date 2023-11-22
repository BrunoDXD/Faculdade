namespace Aula_5
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtagencia = new System.Windows.Forms.TextBox();
            this.txtconta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtsaldo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txttitular = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btncriarconta = new System.Windows.Forms.Button();
            this.txtlimite = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtvalor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btndepositar = new System.Windows.Forms.Button();
            this.btnsacar = new System.Windows.Forms.Button();
            this.btnexibir = new System.Windows.Forms.Button();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.btnpesquisar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Agência:";
            // 
            // txtagencia
            // 
            this.txtagencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtagencia.Location = new System.Drawing.Point(120, 18);
            this.txtagencia.Name = "txtagencia";
            this.txtagencia.Size = new System.Drawing.Size(168, 31);
            this.txtagencia.TabIndex = 1;
            // 
            // txtconta
            // 
            this.txtconta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtconta.Location = new System.Drawing.Point(400, 18);
            this.txtconta.Name = "txtconta";
            this.txtconta.Size = new System.Drawing.Size(173, 31);
            this.txtconta.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(297, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nº Conta:";
            // 
            // txtsaldo
            // 
            this.txtsaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsaldo.Location = new System.Drawing.Point(120, 107);
            this.txtsaldo.Name = "txtsaldo";
            this.txtsaldo.Size = new System.Drawing.Size(168, 31);
            this.txtsaldo.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Saldo:";
            // 
            // txttitular
            // 
            this.txttitular.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttitular.Location = new System.Drawing.Point(120, 63);
            this.txttitular.Name = "txttitular";
            this.txttitular.Size = new System.Drawing.Size(453, 31);
            this.txttitular.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Titular:";
            // 
            // btncriarconta
            // 
            this.btncriarconta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncriarconta.Location = new System.Drawing.Point(341, 158);
            this.btncriarconta.Name = "btncriarconta";
            this.btncriarconta.Size = new System.Drawing.Size(155, 49);
            this.btncriarconta.TabIndex = 8;
            this.btncriarconta.Text = "Criar Conta";
            this.btncriarconta.UseVisualStyleBackColor = true;
            this.btncriarconta.Click += new System.EventHandler(this.btncriarconta_Click);
            // 
            // txtlimite
            // 
            this.txtlimite.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlimite.Location = new System.Drawing.Point(400, 107);
            this.txtlimite.Name = "txtlimite";
            this.txtlimite.Size = new System.Drawing.Size(173, 31);
            this.txtlimite.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(297, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Limite:";
            // 
            // txtvalor
            // 
            this.txtvalor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvalor.Location = new System.Drawing.Point(272, 232);
            this.txtvalor.Name = "txtvalor";
            this.txtvalor.Size = new System.Drawing.Size(235, 31);
            this.txtvalor.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(169, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Valor:";
            // 
            // btndepositar
            // 
            this.btndepositar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndepositar.Location = new System.Drawing.Point(26, 303);
            this.btndepositar.Name = "btndepositar";
            this.btndepositar.Size = new System.Drawing.Size(126, 43);
            this.btndepositar.TabIndex = 13;
            this.btndepositar.Text = "Depositar";
            this.btndepositar.UseVisualStyleBackColor = true;
            this.btndepositar.Click += new System.EventHandler(this.btndepositar_Click);
            // 
            // btnsacar
            // 
            this.btnsacar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsacar.Location = new System.Drawing.Point(230, 303);
            this.btnsacar.Name = "btnsacar";
            this.btnsacar.Size = new System.Drawing.Size(127, 43);
            this.btnsacar.TabIndex = 14;
            this.btnsacar.Text = "Sacar";
            this.btnsacar.UseVisualStyleBackColor = true;
            this.btnsacar.Click += new System.EventHandler(this.btnsacar_Click);
            // 
            // btnexibir
            // 
            this.btnexibir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexibir.Location = new System.Drawing.Point(435, 303);
            this.btnexibir.Name = "btnexibir";
            this.btnexibir.Size = new System.Drawing.Size(126, 43);
            this.btnexibir.TabIndex = 15;
            this.btnexibir.Text = "Exibir Dados";
            this.btnexibir.UseVisualStyleBackColor = true;
            this.btnexibir.Click += new System.EventHandler(this.btnexibir_Click);
            // 
            // btnexcluir
            // 
            this.btnexcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexcluir.Location = new System.Drawing.Point(117, 158);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(155, 49);
            this.btnexcluir.TabIndex = 16;
            this.btnexcluir.Text = "Excluir Conta";
            this.btnexcluir.UseVisualStyleBackColor = true;
            this.btnexcluir.Click += new System.EventHandler(this.btnexcluir_Click);
            // 
            // btnpesquisar
            // 
            this.btnpesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpesquisar.Location = new System.Drawing.Point(579, 18);
            this.btnpesquisar.Name = "btnpesquisar";
            this.btnpesquisar.Size = new System.Drawing.Size(119, 49);
            this.btnpesquisar.TabIndex = 17;
            this.btnpesquisar.Text = "Pesquisar";
            this.btnpesquisar.UseMnemonic = false;
            this.btnpesquisar.UseVisualStyleBackColor = true;
            this.btnpesquisar.Click += new System.EventHandler(this.btnpesquisar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 360);
            this.Controls.Add(this.btnpesquisar);
            this.Controls.Add(this.btnexcluir);
            this.Controls.Add(this.btnexibir);
            this.Controls.Add(this.btnsacar);
            this.Controls.Add(this.btndepositar);
            this.Controls.Add(this.txtvalor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtlimite);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btncriarconta);
            this.Controls.Add(this.txttitular);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtsaldo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtconta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtagencia);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtagencia;
        private System.Windows.Forms.TextBox txtconta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtsaldo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txttitular;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btncriarconta;
        private System.Windows.Forms.TextBox txtlimite;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtvalor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btndepositar;
        private System.Windows.Forms.Button btnsacar;
        private System.Windows.Forms.Button btnexibir;
        private System.Windows.Forms.Button btnexcluir;
        private System.Windows.Forms.Button btnpesquisar;
    }
}


namespace Aula_2_Resolução_
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
            this.txtvalor = new System.Windows.Forms.TextBox();
            this.rbtningresso = new System.Windows.Forms.RadioButton();
            this.rbtnvip = new System.Windows.Forms.RadioButton();
            this.txtadicional = new System.Windows.Forms.TextBox();
            this.lbadicional = new System.Windows.Forms.Label();
            this.btncalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor Ingresso:";
            // 
            // txtvalor
            // 
            this.txtvalor.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtvalor.Location = new System.Drawing.Point(268, 95);
            this.txtvalor.Name = "txtvalor";
            this.txtvalor.Size = new System.Drawing.Size(356, 35);
            this.txtvalor.TabIndex = 2;
            // 
            // rbtningresso
            // 
            this.rbtningresso.AutoSize = true;
            this.rbtningresso.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtningresso.Location = new System.Drawing.Point(112, 175);
            this.rbtningresso.Name = "rbtningresso";
            this.rbtningresso.Size = new System.Drawing.Size(132, 33);
            this.rbtningresso.TabIndex = 3;
            this.rbtningresso.TabStop = true;
            this.rbtningresso.Text = "Ingresso";
            this.rbtningresso.UseVisualStyleBackColor = true;
            this.rbtningresso.CheckedChanged += new System.EventHandler(this.rbtningresso_CheckedChanged);
            // 
            // rbtnvip
            // 
            this.rbtnvip.AutoSize = true;
            this.rbtnvip.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnvip.Location = new System.Drawing.Point(383, 175);
            this.rbtnvip.Name = "rbtnvip";
            this.rbtnvip.Size = new System.Drawing.Size(179, 33);
            this.rbtnvip.TabIndex = 4;
            this.rbtnvip.TabStop = true;
            this.rbtnvip.Text = "Ingresso VIP";
            this.rbtnvip.UseVisualStyleBackColor = true;
            this.rbtnvip.CheckedChanged += new System.EventHandler(this.rbtnvip_CheckedChanged);
            // 
            // txtadicional
            // 
            this.txtadicional.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtadicional.Location = new System.Drawing.Point(268, 246);
            this.txtadicional.Name = "txtadicional";
            this.txtadicional.Size = new System.Drawing.Size(356, 35);
            this.txtadicional.TabIndex = 6;
            // 
            // lbadicional
            // 
            this.lbadicional.AutoSize = true;
            this.lbadicional.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbadicional.Location = new System.Drawing.Point(55, 249);
            this.lbadicional.Name = "lbadicional";
            this.lbadicional.Size = new System.Drawing.Size(196, 29);
            this.lbadicional.TabIndex = 5;
            this.lbadicional.Text = "Valor Adicional:";
            // 
            // btncalcular
            // 
            this.btncalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalcular.Location = new System.Drawing.Point(323, 328);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(206, 62);
            this.btncalcular.TabIndex = 7;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.txtadicional);
            this.Controls.Add(this.lbadicional);
            this.Controls.Add(this.rbtnvip);
            this.Controls.Add(this.rbtningresso);
            this.Controls.Add(this.txtvalor);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtvalor;
        private System.Windows.Forms.RadioButton rbtningresso;
        private System.Windows.Forms.RadioButton rbtnvip;
        private System.Windows.Forms.TextBox txtadicional;
        private System.Windows.Forms.Label lbadicional;
        private System.Windows.Forms.Button btncalcular;
    }
}


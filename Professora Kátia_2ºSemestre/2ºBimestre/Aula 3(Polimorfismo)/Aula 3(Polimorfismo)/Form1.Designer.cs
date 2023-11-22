namespace Aula_3_Polimorfismo_
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
            this.txtmatricula = new System.Windows.Forms.TextBox();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtsalario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rbtnfuncionario = new System.Windows.Forms.RadioButton();
            this.rbtnvendedor = new System.Windows.Forms.RadioButton();
            this.txtbonus = new System.Windows.Forms.TextBox();
            this.lbbonus = new System.Windows.Forms.Label();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.lbtotal = new System.Windows.Forms.Label();
            this.btnmostrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matrícula:";
            // 
            // txtmatricula
            // 
            this.txtmatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmatricula.Location = new System.Drawing.Point(177, 73);
            this.txtmatricula.Name = "txtmatricula";
            this.txtmatricula.Size = new System.Drawing.Size(306, 31);
            this.txtmatricula.TabIndex = 1;
            // 
            // txtnome
            // 
            this.txtnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnome.Location = new System.Drawing.Point(177, 138);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(515, 31);
            this.txtnome.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome:";
            // 
            // txtsalario
            // 
            this.txtsalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsalario.Location = new System.Drawing.Point(177, 205);
            this.txtsalario.Name = "txtsalario";
            this.txtsalario.Size = new System.Drawing.Size(179, 31);
            this.txtsalario.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(54, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Salário:";
            // 
            // rbtnfuncionario
            // 
            this.rbtnfuncionario.AutoSize = true;
            this.rbtnfuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnfuncionario.Location = new System.Drawing.Point(59, 26);
            this.rbtnfuncionario.Name = "rbtnfuncionario";
            this.rbtnfuncionario.Size = new System.Drawing.Size(143, 29);
            this.rbtnfuncionario.TabIndex = 6;
            this.rbtnfuncionario.TabStop = true;
            this.rbtnfuncionario.Text = "Funcionário";
            this.rbtnfuncionario.UseVisualStyleBackColor = true;
            this.rbtnfuncionario.CheckedChanged += new System.EventHandler(this.rbtnfuncionario_CheckedChanged);
            // 
            // rbtnvendedor
            // 
            this.rbtnvendedor.AutoSize = true;
            this.rbtnvendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnvendedor.Location = new System.Drawing.Point(375, 26);
            this.rbtnvendedor.Name = "rbtnvendedor";
            this.rbtnvendedor.Size = new System.Drawing.Size(123, 29);
            this.rbtnvendedor.TabIndex = 7;
            this.rbtnvendedor.TabStop = true;
            this.rbtnvendedor.Text = "Vendedor";
            this.rbtnvendedor.UseVisualStyleBackColor = true;
            this.rbtnvendedor.CheckedChanged += new System.EventHandler(this.rbtnvendedor_CheckedChanged);
            // 
            // txtbonus
            // 
            this.txtbonus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbonus.Location = new System.Drawing.Point(513, 202);
            this.txtbonus.Name = "txtbonus";
            this.txtbonus.Size = new System.Drawing.Size(179, 31);
            this.txtbonus.TabIndex = 9;
            // 
            // lbbonus
            // 
            this.lbbonus.AutoSize = true;
            this.lbbonus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbbonus.Location = new System.Drawing.Point(395, 205);
            this.lbbonus.Name = "lbbonus";
            this.lbbonus.Size = new System.Drawing.Size(79, 25);
            this.lbbonus.TabIndex = 8;
            this.lbbonus.Text = "Bônus:";
            // 
            // txttotal
            // 
            this.txttotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotal.Location = new System.Drawing.Point(249, 274);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(179, 31);
            this.txttotal.TabIndex = 11;
            // 
            // lbtotal
            // 
            this.lbtotal.AutoSize = true;
            this.lbtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtotal.Location = new System.Drawing.Point(54, 277);
            this.lbtotal.Name = "lbtotal";
            this.lbtotal.Size = new System.Drawing.Size(186, 25);
            this.lbtotal.TabIndex = 10;
            this.lbtotal.Text = "Total das Vendas:";
            // 
            // btnmostrar
            // 
            this.btnmostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmostrar.Location = new System.Drawing.Point(301, 343);
            this.btnmostrar.Name = "btnmostrar";
            this.btnmostrar.Size = new System.Drawing.Size(215, 64);
            this.btnmostrar.TabIndex = 12;
            this.btnmostrar.Text = "Mostrar";
            this.btnmostrar.UseVisualStyleBackColor = true;
            this.btnmostrar.Click += new System.EventHandler(this.btnmostrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnmostrar);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.lbtotal);
            this.Controls.Add(this.txtbonus);
            this.Controls.Add(this.lbbonus);
            this.Controls.Add(this.rbtnvendedor);
            this.Controls.Add(this.rbtnfuncionario);
            this.Controls.Add(this.txtsalario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtnome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtmatricula);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmatricula;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtsalario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbtnfuncionario;
        private System.Windows.Forms.RadioButton rbtnvendedor;
        private System.Windows.Forms.TextBox txtbonus;
        private System.Windows.Forms.Label lbbonus;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Label lbtotal;
        private System.Windows.Forms.Button btnmostrar;
    }
}


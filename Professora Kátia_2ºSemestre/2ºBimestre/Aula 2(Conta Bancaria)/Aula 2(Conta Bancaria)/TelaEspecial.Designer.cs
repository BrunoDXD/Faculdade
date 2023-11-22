namespace Aula_2_Conta_Bancaria_
{
    partial class TelaEspecial
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
            this.tbxresgatar = new System.Windows.Forms.TextBox();
            this.tbxaplicar = new System.Windows.Forms.TextBox();
            this.lbconsultar = new System.Windows.Forms.Label();
            this.lbresgatar = new System.Windows.Forms.Label();
            this.lbaplicar = new System.Windows.Forms.Label();
            this.btnconcluir = new System.Windows.Forms.Button();
            this.rbtnconsultar = new System.Windows.Forms.RadioButton();
            this.rbtnresgatar = new System.Windows.Forms.RadioButton();
            this.rbtnaplicar = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbxresgatar
            // 
            this.tbxresgatar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxresgatar.Location = new System.Drawing.Point(285, 266);
            this.tbxresgatar.Name = "tbxresgatar";
            this.tbxresgatar.Size = new System.Drawing.Size(176, 29);
            this.tbxresgatar.TabIndex = 27;
            // 
            // tbxaplicar
            // 
            this.tbxaplicar.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxaplicar.Location = new System.Drawing.Point(58, 266);
            this.tbxaplicar.Name = "tbxaplicar";
            this.tbxaplicar.Size = new System.Drawing.Size(176, 29);
            this.tbxaplicar.TabIndex = 26;
            // 
            // lbconsultar
            // 
            this.lbconsultar.AutoSize = true;
            this.lbconsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbconsultar.Location = new System.Drawing.Point(524, 192);
            this.lbconsultar.Name = "lbconsultar";
            this.lbconsultar.Size = new System.Drawing.Size(0, 24);
            this.lbconsultar.TabIndex = 25;
            // 
            // lbresgatar
            // 
            this.lbresgatar.AutoSize = true;
            this.lbresgatar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbresgatar.Location = new System.Drawing.Point(290, 192);
            this.lbresgatar.Name = "lbresgatar";
            this.lbresgatar.Size = new System.Drawing.Size(180, 48);
            this.lbresgatar.TabIndex = 24;
            this.lbresgatar.Text = "Digite a Quantia que\r\ndeseja resgatar:";
            // 
            // lbaplicar
            // 
            this.lbaplicar.AutoSize = true;
            this.lbaplicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbaplicar.Location = new System.Drawing.Point(54, 192);
            this.lbaplicar.Name = "lbaplicar";
            this.lbaplicar.Size = new System.Drawing.Size(180, 48);
            this.lbaplicar.TabIndex = 23;
            this.lbaplicar.Text = "Digite a Quantia que\r\ndeseja aplicar:";
            // 
            // btnconcluir
            // 
            this.btnconcluir.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconcluir.Location = new System.Drawing.Point(258, 337);
            this.btnconcluir.Name = "btnconcluir";
            this.btnconcluir.Size = new System.Drawing.Size(232, 66);
            this.btnconcluir.TabIndex = 22;
            this.btnconcluir.Text = "Concluir";
            this.btnconcluir.UseVisualStyleBackColor = true;
            // 
            // rbtnconsultar
            // 
            this.rbtnconsultar.AutoSize = true;
            this.rbtnconsultar.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnconsultar.Location = new System.Drawing.Point(546, 145);
            this.rbtnconsultar.Name = "rbtnconsultar";
            this.rbtnconsultar.Size = new System.Drawing.Size(134, 31);
            this.rbtnconsultar.TabIndex = 21;
            this.rbtnconsultar.TabStop = true;
            this.rbtnconsultar.Text = "Consultar";
            this.rbtnconsultar.UseVisualStyleBackColor = true;
            this.rbtnconsultar.CheckedChanged += new System.EventHandler(this.rbtnconsultar_CheckedChanged);
            // 
            // rbtnresgatar
            // 
            this.rbtnresgatar.AutoSize = true;
            this.rbtnresgatar.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnresgatar.Location = new System.Drawing.Point(314, 145);
            this.rbtnresgatar.Name = "rbtnresgatar";
            this.rbtnresgatar.Size = new System.Drawing.Size(127, 31);
            this.rbtnresgatar.TabIndex = 20;
            this.rbtnresgatar.TabStop = true;
            this.rbtnresgatar.Text = "Resgatar";
            this.rbtnresgatar.UseVisualStyleBackColor = true;
            this.rbtnresgatar.CheckedChanged += new System.EventHandler(this.rbtnresgatar_CheckedChanged);
            // 
            // rbtnaplicar
            // 
            this.rbtnaplicar.AutoSize = true;
            this.rbtnaplicar.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnaplicar.Location = new System.Drawing.Point(94, 145);
            this.rbtnaplicar.Name = "rbtnaplicar";
            this.rbtnaplicar.Size = new System.Drawing.Size(103, 31);
            this.rbtnaplicar.TabIndex = 19;
            this.rbtnaplicar.TabStop = true;
            this.rbtnaplicar.Text = "Aplicar";
            this.rbtnaplicar.UseVisualStyleBackColor = true;
            this.rbtnaplicar.CheckedChanged += new System.EventHandler(this.rbtnaplicar_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(215, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(376, 32);
            this.label2.TabIndex = 18;
            this.label2.Text = "Clique na operação desejada:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(278, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 37);
            this.label1.TabIndex = 17;
            this.label1.Text = "Conta Especial";
            // 
            // TelaEspecial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbxresgatar);
            this.Controls.Add(this.tbxaplicar);
            this.Controls.Add(this.lbconsultar);
            this.Controls.Add(this.lbresgatar);
            this.Controls.Add(this.lbaplicar);
            this.Controls.Add(this.btnconcluir);
            this.Controls.Add(this.rbtnconsultar);
            this.Controls.Add(this.rbtnresgatar);
            this.Controls.Add(this.rbtnaplicar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TelaEspecial";
            this.Text = "TelaEspecial";
            this.Load += new System.EventHandler(this.TelaEspecial_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxresgatar;
        private System.Windows.Forms.TextBox tbxaplicar;
        private System.Windows.Forms.Label lbconsultar;
        private System.Windows.Forms.Label lbresgatar;
        private System.Windows.Forms.Label lbaplicar;
        private System.Windows.Forms.Button btnconcluir;
        private System.Windows.Forms.RadioButton rbtnconsultar;
        private System.Windows.Forms.RadioButton rbtnresgatar;
        private System.Windows.Forms.RadioButton rbtnaplicar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
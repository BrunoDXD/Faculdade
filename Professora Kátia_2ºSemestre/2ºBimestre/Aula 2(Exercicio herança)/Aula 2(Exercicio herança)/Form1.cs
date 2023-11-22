using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_2_Exercicio_herança_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtqtdingresso_TextChanged(object sender, EventArgs e)
        {

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            Ingresso i = new Ingresso();
            MessageBox.Show($"Quantidade de Ingressos: {txtqtdingresso.Text}\n" +
                $"Quantidade de VIPs: {txtqtdvip}\n" +
                $"Valor: {(i.ValorIngresso*Convert.ToDouble(txtqtdingresso.Text))}");
            
        }
    }
}

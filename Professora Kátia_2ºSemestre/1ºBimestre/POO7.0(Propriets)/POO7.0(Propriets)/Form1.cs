using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO7._0_Propriets_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Produto prod = new Produto();

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            prod.Nome = txtNome.Text;
            prod.Preco = Convert.ToDouble(txtPreco.Text);
            MessageBox.Show("Nome: "+prod.Nome + "\nPreço: " + prod.Preco.ToString("C") +
                "\nValor a Pagar: " +
                (prod.Preco * Convert.ToInt32(txtQuantidade.Text)).ToString("C"));
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula_conexão_bd
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        Form tela = new Form();

        private void btnProduto_Click(object sender, EventArgs e)
        {
            tela?.Close();
            tela = new TelaProduto
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill,
            };
            pnlTela.Controls.Add(tela);
            tela.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tela?.Close();
            tela = new TelaCategoria
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill,
            };
            pnlTela.Controls.Add(tela);
            tela.Show();
        }
    }
}

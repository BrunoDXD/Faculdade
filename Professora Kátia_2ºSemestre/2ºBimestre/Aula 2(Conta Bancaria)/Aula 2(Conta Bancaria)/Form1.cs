using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_2_Conta_Bancaria_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnespecial.Enabled = false;
            btnpoupanca.Enabled = false;
        }
        Form tela;
        ContaBancaria nova;
        private void btnespecial_Click(object sender, EventArgs e)
        {
            lbnome.Visible = false;
            tbxnome.Visible = false;
            lbnuco.Visible = false;
            tbxnuco.Visible = false;
            lbsal.Visible = false;
            tbxsal.Visible = false;
            lbconfirma.Visible = false;
            btncadastrar.Visible = false;

            tela?.Close();
            tela = new TelaEspecial
            {
                FormBorderStyle = FormBorderStyle.None,
                TopLevel = false,
                Dock = DockStyle.Fill,
            };
            pnlTelas.Controls.Add(tela);
            tela.Show();           
        }

        private void btnpoupanca_Click(object sender, EventArgs e)
        {
            lbnome.Visible = false;
            tbxnome.Visible = false;
            lbnuco.Visible = false;
            tbxnuco.Visible = false;
            lbsal.Visible = false;
            tbxsal.Visible = false;
            lbconfirma.Visible = false;
            btncadastrar.Visible = false;

            tela?.Close();
            tela = new TelaPoupanca
            {
                FormBorderStyle = FormBorderStyle.None,
                TopLevel = false,
                Dock = DockStyle.Fill,
            };
            pnlTelas.Controls.Add(tela);
            tela.Show();
        }

        private void btncadastrar_Click(object sender, EventArgs e)
        {
            nova = new ContaBancaria();
            nova.cliente = tbxnome.Text;
            nova.numconta = Convert.ToInt32(tbxnuco.Text);
            
            TelaPoupanca destino = new TelaPoupanca();
            destino.Transfere = tbxsal.Text;
            tbxnome.Text = "";
            tbxnuco.Text = null;
            
            lbconfirma.Text = "Cadastro realizado com sucesso!";
            btnespecial.Enabled = true;
            btnpoupanca.Enabled = true;
            
            

        }

        private void tbxnome_TextChanged(object sender, EventArgs e)
        {

        }
        

    }
}

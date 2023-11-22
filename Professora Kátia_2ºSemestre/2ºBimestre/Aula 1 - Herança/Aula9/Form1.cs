using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label4.Visible = false;
            txtcpf.Visible = false;
            label5.Visible = false;
            txtcnpj.Visible = false;
        }
        Fisica a = new Fisica("", "", "", "");
        Juridica j = new Juridica("", "", "", "");

        private void btnmostrar_Click(object sender, EventArgs e)
        {
            if (rbtnfisica.Checked)
            {
                a.Cpf = txtcpf.Text;
                a.Nome = txtnome.Text;
                a.Endereco = txtendereco.Text;
                a.Telefone = txttelefone.Text;
                MessageBox.Show($"Nome: {a.Nome}\nCPF: {a.Cpf}" +
                $"\nEndereço: {a.Endereco}\nTelefone: {a.Telefone}");
            }
            if (rbtnjuridica.Checked)
            {
                j.Cnpj = txtcpf.Text;
                j.Nome = txtnome.Text;
                j.Endereco = txtendereco.Text;
                j.Telefone = txttelefone.Text;
                MessageBox.Show($"Nome: {j.Nome}\nCNPJ: {j.Cnpj}" +
                $"\nEndereço: {j.Endereco}\nTelefone: {j.Telefone}");
            }
        }

        private void rbtnfisica_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnfisica.Checked==true)
            {
                rbtnjuridica.Checked = false;
                label5.Visible = false;
                txtcnpj.Visible = false;
                label4.Visible = true;
                txtcpf.Visible = true;
            }
            
        }

        private void rbtnjuridica_CheckedChanged(object sender, EventArgs e)
        {

            if (rbtnjuridica.Checked)
            {
                rbtnfisica.Checked = false;
                label4.Visible = false;
                txtcpf.Visible = false;
                label5.Visible = true;
                txtcnpj.Visible = true;
            }
            
        }
    }
}

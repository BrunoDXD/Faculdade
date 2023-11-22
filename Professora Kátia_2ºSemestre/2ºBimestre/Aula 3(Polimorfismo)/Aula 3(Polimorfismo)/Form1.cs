using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_3_Polimorfismo_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lbtotal.Visible = false;
            txttotal.Visible = false;
            lbbonus.Visible = false;
            txtbonus.Visible = false;
        }

        private void rbtnfuncionario_CheckedChanged(object sender, EventArgs e)
        {
            rbtnvendedor.Checked = false;
            lbtotal.Visible = false;
            txttotal.Visible = false;
            lbbonus.Visible = false;
            txtbonus.Visible = false;
        }

        private void rbtnvendedor_CheckedChanged(object sender, EventArgs e)
        {            
            lbtotal.Visible = true;
            txttotal.Visible = true;
            rbtnfuncionario.Checked = false;
            lbbonus.Visible = true;
            txtbonus.Visible = true;
        }

        private void btnmostrar_Click(object sender, EventArgs e)
        {
            if (rbtnfuncionario.Checked)
            {
                Funcionario f = new Funcionario();
                f.Nome = txtnome.Text;
                f.Matricula = Convert.ToInt32(txtmatricula.Text);
                f.Salario = Convert.ToDouble(txtsalario.Text);
               if(txtbonus.Text.Equals(""))
                {
                    MessageBox.Show(f.MostrarDados());
                }
                else
                {
                    MessageBox.Show(f.MostrarDados(Convert.ToDouble(txtbonus.Text)));
                }
            }

            if (rbtnvendedor.Checked)
            {
                Vendedor v = new Vendedor();
                v.Nome = txtnome.Text;
                v.Matricula = Convert.ToInt32(txtmatricula.Text);
                v.Salario = Convert.ToDouble(txtsalario.Text);
                MessageBox.Show(v.MostrarDados(Convert.ToDouble(txtbonus.Text)));
                v.ValorVenda = Convert.ToDouble(txttotal);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_2_Resolução_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lbadicional.Visible = false;
            txtadicional.Visible = false;
        }
        Ingresso x;
        private void button1_Click(object sender, EventArgs e)
        {
            if (rbtningresso.Checked)
            {
                x = new Ingresso(Convert.ToDouble(txtvalor.Text));
                MessageBox.Show(x.ToString());
            }
            if (rbtnvip.Checked)
            {
                IngressoVip x = new IngressoVip(Convert.ToDouble(txtvalor.Text), 
                    Convert.ToDouble(txtadicional.Text));
                MessageBox.Show(x.calcular());
            }
        }

        private void rbtningresso_CheckedChanged(object sender, EventArgs e)
        {
            rbtnvip.Checked = false;
            lbadicional.Visible = false;
            txtadicional.Visible = false;
        }

        private void rbtnvip_CheckedChanged(object sender, EventArgs e)
        {
            rbtningresso.Checked = false;
            lbadicional.Visible = true;
            txtadicional.Visible = true;

        }
    }
}

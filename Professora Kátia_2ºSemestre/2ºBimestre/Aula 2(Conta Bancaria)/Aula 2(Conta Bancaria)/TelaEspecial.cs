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
    public partial class TelaEspecial : Form
    {
        public TelaEspecial()
        {
            InitializeComponent();
            lbaplicar.Visible = false;
            tbxaplicar.Visible = false;
            lbresgatar.Visible = false;
            tbxresgatar.Visible = false;
            lbconsultar.Visible = false;
        }

        private void TelaEspecial_Load(object sender, EventArgs e)
        {

        }

        private void rbtnaplicar_CheckedChanged(object sender, EventArgs e)
        {
            lbaplicar.Visible = true;
            tbxaplicar.Visible = true;
            lbresgatar.Visible = false;
            tbxresgatar.Visible = false;
            lbconsultar.Visible = false;
        }

        private void rbtnresgatar_CheckedChanged(object sender, EventArgs e)
        {
            lbaplicar.Visible = false;
            tbxaplicar.Visible = false;
            lbresgatar.Visible = true;
            tbxresgatar.Visible = true;
            lbconsultar.Visible = false;
        }

        private void rbtnconsultar_CheckedChanged(object sender, EventArgs e)
        {
            lbaplicar.Visible = false;
            tbxaplicar.Visible = false;
            lbresgatar.Visible = false;
            tbxresgatar.Visible = false;
            lbconsultar.Visible = true;
        }
    }
}

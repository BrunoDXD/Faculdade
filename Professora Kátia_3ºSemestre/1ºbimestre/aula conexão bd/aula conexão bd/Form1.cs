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
    public partial class TelaCategoria : Form
    {
        public TelaCategoria()
        {
            InitializeComponent();
        }
        conexao con;
        private void btnsalvar_Click(object sender, EventArgs e)
        {
            string insere = "insert into tb01_categoria values(" +
                txtid.Text + ", '" + txtdescricao.Text + "')";
            if (con.Executa(insere)) MessageBox.Show("Cadastrado com Sucesso");
            else MessageBox.Show("não foi possível cadastrar");
        }

        private void btnatualizar_Click(object sender, EventArgs e)
        {
            string atualiza = "update tb01_categoria set tb01_id='" +
                txtid.Text + "', tb01_descricao='" + txtdescricao.Text +
                "' where tb01_id=" + txtid.Text;
            if (con.Executa(atualiza))
                MessageBox.Show("Cadastrado com sucesso!");
            else
                MessageBox.Show("Não foi possivel atualizar!");
        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            string excluir = "delete from tb01_categoria where tb01_id" +
               txtid.Text;
            if (con.Executa(excluir))
                MessageBox.Show("Cadastrado com sucesso!");
            else
                MessageBox.Show("Não foi possivel excluir!");
        }

        private void txtid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                DataTable dt = con.Retorna(
                    "select * from tb01_categoria where tb01_id=" + txtid.Text);
                txtdescricao.Text = dt.Rows[0]["tb01_descricao"].ToString();
                txtid.Text = null;
            }
        }
    }
}

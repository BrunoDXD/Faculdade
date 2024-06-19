using Mysqlx.Crud;
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
    public partial class TelaProduto : Form
    {
        public TelaProduto()
        {
            InitializeComponent();
        }

        conexao con = new conexao();

        private void TelaProduto_Load(object sender, EventArgs e)
        {
            cbxCategoria.DataSource = null;
            cbxCategoria.DataSource = con.Retorna(
                "select * from tb01_categoria");
            cbxCategoria.DisplayMember = "tb01_descricao";
            cbxCategoria.ValueMember = "tb01_id";
        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            string insere = "insert into tb02_produtos values " +
                "(" + txtcodigo.Text + ", '" + txtnome.Text + "', '" +
                txtdescricao.Text + "', " + cbxCategoria.SelectedValue +
                ", "+txtvalor.Text+");";
            if (con.Executa(insere))
                MessageBox.Show("Cadastrado com sucesso!");
            else
                MessageBox.Show("Não foi possivel cadastrar!");
        }

        private void btnatualizar_Click(object sender, EventArgs e)
        {
            string atualiza = "update tb02_produtos set tb02_produto='" +
                txtnome.Text + "', tb02_descricao='" + txtdescricao.Text +
                "', tb02_categoria=" + cbxCategoria.SelectedValue + ", " +
                "tb02_valor=" + txtvalor.Text + " where tb02_codigo=" + txtcodigo.Text;
            if (con.Executa(atualiza))
                MessageBox.Show("Cadastrado com sucesso!");
            else
                MessageBox.Show("Não foi possivel atualizar!");
        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            string excluir = "delete from tb02_produtos where tb02_codigo" +
                txtcodigo.Text;
            if (con.Executa(excluir))
                MessageBox.Show("Cadastrado com sucesso!");
            else
                MessageBox.Show("Não foi possivel excluir!");
        }

        private void txtcodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                DataTable dados = con.Retorna(
                    "Select * from tb02_produtos where tb02_codigo" +
                    txtcodigo.Text
                    );
                txtnome.Text = dados.Rows[0]["tb02_nome"].ToString();
                txtdescricao.Text = dados.Rows[0]["tb02_descricao"].ToString();
                cbxCategoria.SelectedValue = Convert.ToInt32(
                    dados.Rows[0]["tb02_categoria"].ToString());
                txtvalor.Text = dados.Rows[0]["tb02_valor"].ToString();
            }
        }
    }
}

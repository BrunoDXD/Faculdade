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

namespace ProjetoConexao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Conexao con = new Conexao();
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string insere = "insert into tb03_consulta values (" + txtid.Text + ", '" + txtdata.Text + "', '" +
                txthorario.Text + "', '" + txtlocal.Text + "', " + txtcpf.Text + ", " + txtmedico + ");";

            if (con.Executa(insere))
                MessageBox.Show("Cadastrado com sucesso! ;)");
            else
                MessageBox.Show("Erro ao Cadastrar! :(");
            
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            string atualiza = "upadate tb03_consulta set tb03_data='" + txtdata + "', tb03_horario='" + txthorario +
                "', tb03_local='" + txtlocal + "', tb03_cpf=" + txtcpf + ", tb03_id_crm=" + txtmedico + " where tb03_id=" + txtid + ";";

            if (con.Executa(atualiza))
                MessageBox.Show("Atualizado com sucesso! ;)");
            else
                MessageBox.Show("Erro ao Atualizar! :(");
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            string excluir = "delete * from tb03_consulta where tb03_id=" + txtid + ";";

            if (con.Executa(excluir))
                MessageBox.Show("excluido com sucesso! ;)");
            else
                MessageBox.Show("Erro ao excluir! :(");

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DataTable dados = con.Retorna("select * from tb03_consulta where tb03_id=" + txtid);
            txtcpf.Text = dados.Rows[0]["tb03_cpf"].ToString();
            txtmedico.Text = dados.Rows[0]["tb03_id_crm"].ToString();
            txtlocal.Text = dados.Rows[0]["tb03_local"].ToString();
            txtdata.Text = dados.Rows[0]["tb03_data"].ToString();
            txthorario.Text = dados.Rows[0]["tb03_horario"].ToString();

        }
    }
}

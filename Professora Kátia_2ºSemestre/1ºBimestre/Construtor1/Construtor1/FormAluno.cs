using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Construtor1
{
    public partial class FormAluno : Form
    {
        public FormAluno()
        {
            InitializeComponent();
        }
        Curso[] cursos = {new Curso(), new Curso("Análise e Desenvolvimento de Sistemas"),
        new Curso("Direito"), new Curso("Fisioterapia")};

        private void FormAluno_Load(object sender, EventArgs e)
        {
            for(int i = 0;i< cursos.Length; i++)
            {
                cbxCurso.Items.Add(cursos[i].getNome());
            }
        }
        Aluno alguem;
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Aluno alguem = new Aluno(
                Convert.ToInt32(txtRa.Text), txtNome.Text, 
                cbxCurso.Text, txtTurma.Text
                );
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            txtRa.Text = alguem.getra().ToString();
            txtNome.Text = alguem.getnome();
            cbxCurso.SelectedText = alguem.getcurso();
            txtTurma.Text = alguem.getturma();
        }
    }
}

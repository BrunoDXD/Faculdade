using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construtor1
{
    internal class Curso
    {
        string nome, periodo;
        public Curso()
        {
            this.nome = "Administração";
            this.periodo = "Noturno";
        }

        public Curso(string nome)
        {
            this.nome = nome;
            this.periodo = "noturno";
        }

        public string getNome() { return this.nome; }
        public void setNome(string nome) {  this.nome = nome; }
        public string getPeriodo() { return this.periodo; }
        public void setPeriodo(string periodo) { this.periodo=periodo; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construtor1
{
    internal class Aluno
    {
        int ra;
        string nome, curso, turma;
        public Aluno(int ra, string nome, string curso ,string turma)
        {
            this.ra=ra;
            this.nome=nome;
            this.curso=curso;
            this.turma=turma;
        }
        public int getra() { return ra; }
        public string getnome() { return nome;}
        public string getcurso() {  return curso;}
        public string getturma() {  return turma;}
    }
}

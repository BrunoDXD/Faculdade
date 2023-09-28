using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO5._0__Agenda_
{
    internal class Contato
    {
        string nome;
        int idade, numero;

        public void setNome(string nome) { this.nome = nome; }
        public void setIdade(int idade) { this.idade = idade; }
        public void setNumero(int numero) {  this.numero = numero; }
        public string getNome() { return nome; }
        public int getIdade() { return idade;}
        public int getNumero() { return numero; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace POO6._0_URNAFORMS_
{
    internal class Candidato
    {
        //Declaraçao dos atributos
        string nome, chapa, foto;
        int voto, numero;
        //Construtor
        public Candidato(string nome, string chapa, string foto, int numero, int voto)
        {
            this.nome = nome;
            this.chapa = chapa;
            this.foto = foto;
            this.numero = numero;
            this.voto = voto;
            
        }
        public void setVoto(int voto) { this.voto = voto; }
        public string getNome() { return this.nome; }
        public string getChapa() { return this.chapa; }
        public int getVoto() { return this.voto; }
        public int getNumero() { return this.numero; }
        public string getFoto() { return this.foto; }


    }
}

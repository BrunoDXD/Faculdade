using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Aula6
{
    internal class Candidato
    {
        string nome, chapa, foto;
        int numero, voto;
        public Candidato(string nome, string chapa, string foto, int numero, int voto)
        {
            this.nome = nome;
            this.chapa = chapa;
            this.foto = foto;
            this.numero = numero;
            this.voto = voto;
        }
        public string getNome() { return this.nome; }
        public string getChapa() { return this.chapa; }
        public string getFoto() { return this.foto; }
        public int getNumero() { return this.numero;}
        public int getVoto() { return this.voto; }
        public void setVoto(int voto) { this.voto = voto; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO4._0_Futebol_
{
    internal class Jogador
    {
        string nome, posicao, nacionalidade;
        DateTime nascimento;
        double altura, peso;

        public void setNome(string nome) { this.nome = nome; }
        public void setPosicao(string posi) { this.posicao = posi; }
        public void setNacionalidade(string nac) { this.nacionalidade = nac; }
        public void setNascimento(DateTime nasc) { this.nascimento = nasc; }
        public void setAltura(double alt) { this.altura = alt; }
        public void setPeso(double peso) { this.peso = peso; }
        public string getNome() { return nome; }
        public string getPosicao() { return posicao; }
        public string getNacionalidade() { return nacionalidade; }
        public DateTime getNascimento() { return nascimento; } 
        public double getAltura() { return altura; }
        public double getPeso() { return peso; }

        public int CalculaIdade()
        {
            int idade = DateTime.Now.Year-this.nascimento.Year;
            if (this.nascimento.DayOfYear > DateTime.Now.DayOfYear)  idade--; 
            return idade;
        }

        public int CalculaAposentadoria()
        {
            int id = CalculaIdade();
            int tempo = 0;
            if (this.posicao.Equals("defesa")) tempo = 40 - id;
            if (this.posicao.Equals("meio-campo")) tempo = 38 - id;
            if (this.posicao.Equals("ataque")) tempo = 35 - id;
            return tempo;


        }



    }
}

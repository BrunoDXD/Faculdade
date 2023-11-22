using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO1
{
    internal class Cliente
    {
        string nome, cpf, endereco, celular;

        public void atribuir(string nome, string cpf, string endereco, string celular)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.endereco = endereco;
            this.celular = celular;
        }

        public string retornar()
        {
            string texto = "Nome:" + this.nome + "\tCPF:" + this.cpf + "\tEndereço:" + this.endereco
                + "\tCelular:" + this.celular;
            return texto;
        }
    }
}

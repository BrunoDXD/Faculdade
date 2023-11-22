using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO3._0
{
    internal class Conta
    {
        //atributos
        string nome, cpf;
        double saldo;

        //metodos
        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public string getNome()
        {
            return this.nome;   
        }

        public void setSaldo(double saldo)
        {
            this.saldo = saldo;
        }

        public double getSaldo()
        {
            return this.saldo;
        }

        public void setCpf(string cpf)
        {
            this.cpf = cpf;
        }

        public string getCpf()
        {
            return this.cpf;
        }

        public void depositar(double valor)
        {
            this.saldo += valor;
        }

        public bool sacar(double valor)
        {
           if(this.saldo >= valor)
            {
                this.saldo -= valor;
                return true;
            }
            else
            {
                return false;
            }

        }

    }
}

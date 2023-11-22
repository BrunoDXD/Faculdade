using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace POO2._0
{
    internal class Funcionario
    {
        //declaraçao dos atributos
        string nome, cargo;
        double salario;
        DateTime nascimento;

        //declaraçao dos métodos
        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public void setCargo(string cargo)
        {
            this.cargo = cargo;
        }

        public void setSalario(double salario)
        {
            this.salario = salario;
        }

        public void setNascimento(DateTime nascimento)
        {
            this.nascimento = nascimento;
        }

        public string getNome()
        {
            return this.nome;
        }

        public string getCargo()
        {
            return this.cargo;
        }

        public double getSalario()
        {
            return this.salario;
        }

        public DateTime getNascimento()
        {
            return this.nascimento;
        }

        public int calculaIdade()
        {
            int idade = DateTime.Now.Year - this.nascimento.Year;
            if (this.nascimento.DayOfYear > DateTime.Now.DayOfYear)
            {
                idade--;
            }
            return idade;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario[] todos = new Funcionario[10];

            for(int i=0; i<2; i++)
            {
                //instanciaçao de objeto
                Funcionario alguem = new Funcionario();
                Console.WriteLine("Informe o nome");
                alguem.setNome(Console.ReadLine());
                Console.WriteLine("Informe o cargo");
                alguem.setCargo(Console.ReadLine());
                Console.WriteLine("Informe o salario");
                alguem.setSalario(Convert.ToDouble(Console.ReadLine()));
                Console.WriteLine("Informe a data de nascimento");
                alguem.setNascimento(Convert.ToDateTime(Console.ReadLine()));
                todos[i] = alguem;
                Console.Clear();
            }
            //exibe todos os objetos do vetor
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine($"Funcionario: {todos[i].getNome()}," +
                    $" Cargo: {todos[i].getCargo()}, Salário: {todos[i].getSalario()}," +
                    $" Data de Nascimento: {todos[i].getNascimento()}, Idade: " +
                    $"{todos[i].calculaIdade()}");
            }
            //busca apenas um funcionario
            Console.WriteLine("informe o nome do Funcionario:");
            string busca = Console.ReadLine();
            for (int i = 0; i < 2; i++)
            {
                if (todos[i].getNome().Equals(busca))
                    {
                Console.WriteLine($"Funcionario: {todos[i].getNome()}," +
                    $" Cargo: {todos[i].getCargo()}, Salário: {todos[i].getSalario()}," +
                    $" Data de Nascimento: {todos[i].getNascimento()}, Idade: " +
                    $"{todos[i].calculaIdade()}");
                    }
            }
            Console.ReadKey();
        }
    }
}

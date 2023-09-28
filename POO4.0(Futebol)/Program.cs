using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO4._0_Futebol_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Jogador jog = new Jogador();
            Console.WriteLine("Informe o nome do Jogador");
            jog.setNome(Console.ReadLine());
            Console.WriteLine("Informe a Posição");
            jog.setPosicao(Console.ReadLine());
            Console.WriteLine("Informe a nascionalidade");
            jog.setNacionalidade(Console.ReadLine());
            Console.WriteLine("Informe a altura");
            jog.setAltura(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("Informe o peso do jogador");
            jog.setPeso(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("Informe a data de nascimento");
            jog.setNascimento(Convert.ToDateTime(Console.ReadLine()));

            Console.WriteLine("\n\nInformações do jogador");
            Console.WriteLine($"jogador: {jog.getNome()}\n Posição: {jog.getPosicao()}\n" +
                $"Nacionalidade: {jog.getNacionalidade()}\n Peso: {jog.getPeso()}\n " +
                $"Altura: {jog.getAltura()}\n Data de nascimento: {jog.getNascimento()}\n " +
                $"Idade: {jog.CalculaIdade()} anos \n" +
                $" Tempo que falta para aposentar: {jog.CalculaAposentadoria()} anos");

            Console.ReadKey();


        }
    }
}

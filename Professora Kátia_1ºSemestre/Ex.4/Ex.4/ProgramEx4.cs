using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = new Random().Next(1, 100);
            int chute, pegou = 0;

            for (int cont  = 0; cont < 5; cont++)
            {
                Console.WriteLine(cont+1 + " - " +
                    "Atire no Marciano! ");
                chute = Convert.ToInt32(Console.ReadLine());

                if (chute == x)
                {
                    Console.WriteLine("Fui Atingido!");
                    pegou = chute;
                    cont = 5;
                }
                else if (chute > x) Console.WriteLine("Estou mais pra Esquerda!");

                else Console.WriteLine("Estou mais pra Direita");
                Console.ReadKey();
                Console.Clear();
            }
            if (pegou != x) Console.WriteLine("Te Peguei!");

            
            Console.ReadKey();
        }
    }
}

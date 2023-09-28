using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade;
            int ID20 = 0;
            int ID50 = 0;
            int ID70 = 0;
            int IDMaior = 0;

            for (int c = 0; c < 10; c++)
            {
                Console.WriteLine("Digite sua Idade: ");
                idade = Convert.ToInt32(Console.ReadLine());

                if (idade <= 20) ID20++;
                else if (idade > 20 && idade <= 50) ID50++;
                else if (idade > 50 && idade <= 70) ID70++;
                else IDMaior++;

            }
                Console.WriteLine("Quatidade de Pessoas até 20 anos: " + ID20);
                Console.WriteLine("Quatidade de Pessoas entre 20 e 50 anos: " + ID50);
                Console.WriteLine("Quatidade de Pessoas entre 50 e 70 anos: " + ID70);
                Console.WriteLine("Quatidade de Pessoas acima de 70 anos: " + IDMaior);
                Console.WriteLine("Porcentagem de pessoas até 20 anos: " + ID20 * 1000 / 100+"%");
                Console.WriteLine("Porcentagem de pessoas acima de 70 anos: " + IDMaior * 1000 / 100+"%");
                Console.ReadKey();


            


        }
    }
}

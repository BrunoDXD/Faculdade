﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char sexo;
            string nome;
            int idade;

            Console.WriteLine("Vamos calcular o desconto em sua apolice de seguros");
            Console.WriteLine("Digite seu nome: ");
            nome = Console.ReadLine();

            Console.WriteLine("Digite o seu sexo (M/F): ");
            sexo = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Digite sua idade");
            idade = int.Parse(Console.ReadLine());
           
            if (idade < 18)
            { Console.WriteLine("Desconto disponível apenas para maiores de 18 anos");
            }
            if (sexo == 'M' || sexo == 'm')
            {
               if (idade >= 18 && idade<=25)
                    {

                    Console.WriteLine("O desconto concedido é 3%");
                }

                if (idade >= 26 && idade <= 55)
                {

                    Console.WriteLine("O desconto concedido é 6%");
                }

                if (idade >= 56 )
                {

                    Console.WriteLine("O desconto concedido é 9%");
                }


            }
            else if(sexo == 'F' || sexo == 'f')
            {
                if (idade >= 18 && idade <= 25)
                {

                    Console.WriteLine("O desconto concedido é 4%");
                }

                if (idade >= 26 && idade <= 55)
                {

                    Console.WriteLine("O desconto concedido é 7%");
                }

                if (idade >= 56)
                {

                    Console.WriteLine("O desconto concedido é 10%");
                }


            }
            else 
            {
                 Console.WriteLine("Sexo não reconhecido");
            }

            Console.ReadKey();

        }
    }
}

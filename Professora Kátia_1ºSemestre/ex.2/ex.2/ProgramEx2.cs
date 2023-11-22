using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 1, ant = 1, elemento, contador = 0, result;

            
                Console.WriteLine("Para Mostrar a Sequência de Fibonacci, Digite a Quantidade de elementos: ");
                elemento = Convert.ToInt32(Console.ReadLine());

            if (elemento > 3)
            {
                Console.Write("1, 1, ");
                while (contador < (elemento - 2))
                {
                    result = num + ant;
                    Console.Write($"{result}, ");
                    ant = num;
                    num = result;
                    contador++;

                }
            }
            else
            {
                Console.WriteLine("Por Favor Digite Apenas um Número Maior que 3");
            }
            Console.ReadKey();

        }
    }
}

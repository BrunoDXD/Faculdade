using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[,] matriz = new double[4,3];
            double MaiEstP2 = 0, MenEstP1 = 100000;
            for (int l = 0; l < 4; l++)
            {
                for (int c = 0; c < 3; c++)
                {
                    Console.WriteLine($"Digite a quantidade do Armazém {l + 1}, Produto {c + 1}");
                    matriz[l, c] = Convert.ToDouble(Console.ReadLine());
                    Console.Clear();
                    if (matriz[l, 2] > MaiEstP2) MaiEstP2 = l;
                    if (matriz[l, 1] < MenEstP1) MenEstP1 = l;
                }
            }
            Console.WriteLine("          Produto 1   Produto 2   Produto 3");
            
            for (int l = 0; l < 4; l++)
            {
                Console.Write($"Armazém {l + 1}");
                for (int c = 0; c < 3; c++)
                {
                    Console.Write($"    {matriz[l, c]}     ");
                    
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine($"A Maior Quantidade do Produto 2 está no armazém {MaiEstP2 + 1}");
            Console.WriteLine($"A Menor Quantidade do Produto 1 está no armazém {MenEstP1 + 1}");
            Console.ReadKey();
        }
    }
}

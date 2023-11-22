using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFaculdade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int l, c;
            //double[,] notas = new double[3, 3];
            //for (l = 0; l < 3; l++)
            //{
            //    for (c = 0; c < 3; c++)
            //    {
            //        Console.WriteLine("Informe a nota: ");
            //        notas[l, c] = Convert.ToDouble(Console.ReadLine());
            //    }
            //}
            //Console.Clear();
            //Console.WriteLine("\nNotas digitadas:\n");
            //for (l = 0; l < 3; l++)
            //{
            //    for (c = 0; c < 3; c++)
            //    {
            //        Console.Write(notas[l, c] + "\t");
            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadKey();



            //

            double[,] bois = new double[5, 6];
            int lin, col, lPesado = 0, cPesado = 0, lLeve = 0, cLeve = 0;
            double media = 0, pesado = 0, leve = 100000;

            for (lin = 0; lin < 5; lin++)
            {
                for (col = 0; col < 6; col++)
                {
                    Console.WriteLine("Informe o Peso");
                    bois[lin, col] = Convert.ToDouble(Console.ReadLine());

                }
            }

            for (lin = 0; lin < 5; lin++)
            {
                for (col = 0; col < 6; col++)
                {
                    media += bois[lin, col];

                    if (bois[lin, col] > pesado)
                    {
                        pesado = bois[lin, col];
                        lPesado = lin;
                        cPesado = col;
                    }
                    if (bois[lin, col] < leve)
                    {
                        leve = bois[lin, col];
                        lLeve = lin;
                        cLeve = col;
                    }

                }
            }
            Console.WriteLine("O Boi mais Pesado está na Posição linha " + lPesado + " coluna " +
                +cPesado + " e o peso é " + pesado + " Kg");
            Console.WriteLine("O Boi mais Leve está na Posição linha " + lLeve + " coluna " +
                +cLeve + " e o peso é " + leve + " Kg");
            Console.WriteLine("A Média do Peso dos bois é " + media / 30 + " Kg");
            Console.ReadKey();

        }
    }
}

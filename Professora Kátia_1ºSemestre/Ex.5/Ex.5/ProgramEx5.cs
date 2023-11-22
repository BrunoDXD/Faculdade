using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] sexo = new char[10];
            int[] idade = new int[10];
            int sexM = 0, sexF = 0, idadeM = 0, idadeF = 0, idadeNovaF = 0, idadeVelhaM = 0;
            
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite sua Idade: ");

                idade[i] = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Digite seu sexo:    M para Masculino      F para Feminino");
             
                sexo[i] = Convert.ToChar(Console.ReadLine());
              
                   if (sexo[i] == 'm' || sexo[i] == 'M' || sexo[i] == 'F' || sexo[i] == 'f')
                   {

                        if (sexo[i] == 'm' || sexo[i] == 'M')
                        {
                           sexM++;
                           idadeM += idade[i];
                        }
                        else
                        {
                           sexF++;
                           idadeF += idade[i];
                        }
                       if ((sexo[i] == 'F' || sexo[i] == 'f') && idade[i] >= 25 && idade[i] <= 50)
                        {
                            idadeNovaF++;
                        }
                          if ((sexo[i] == 'M' || sexo[i] == 'm') && idade[i] >= 50 && idade[i] <= 75)
                        {
                          idadeVelhaM++;
                        }
                          Console.Clear();
                    }

                    else(Console.WriteLine("Sexo não reconhecido"););

            }
            Console.WriteLine("Percentual de Mulheres entre 25 e 50 anos: " + idadeNovaF * 10 + "%");
            Console.WriteLine("Percentual de Homens entre 50 e 75 anos: " + idadeVelhaM * 10 + "%");
            Console.WriteLine("Média de idade dos Homens: " + idadeM / 10);
            Console.WriteLine("Média de idade das Mulheres: " + idadeF / 10);
            Console.ReadKey();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO8._0_List_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Produto> Lista = new List<Produto>();
            Lista.Add(new Produto(1, "Óleo", 8.8));
            Lista.Add(new Produto(2, "Arroz", 25.8));
            Lista.Insert(4, new Produto(3, "Feijão", 8.9));
            Produto p = new Produto(0, "", 0);

            Console.WriteLine("Informe o Codigo do Produto");
            p.Codigo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o Descrição do Produto");
            p.Descricao = Console.ReadLine();

            Console.WriteLine("Informe o Preço do Produto");
            p.Preco = Convert.ToDouble(Console.ReadLine());

            Lista.Insert(0, p);
            Lista.Reverse();

            for (int i = 0; i < Lista.Count; i++)
            {
                Console.WriteLine(Lista[i].Codigo+" - " + Lista[i].Descricao
                    +" - " + Lista[i].Preco.ToString("C"));
            }
            Console.ReadKey();








            //List<string> nome = new List<string>();
            //List<int> numero = new List<int>();
            //nome.Add("Joana");
            //nome.Add("Frederico");           //Adiciona nome
            //nome.Insert(0, "Mariana");       //Adiciona nome e posicao
            //nome.Remove("Joana");            //remove pelo nome
            //nome.RemoveAt(1);               //remove pela posicao

        }
    }
}

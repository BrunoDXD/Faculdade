using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO5._0__Agenda_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int id = 0;
            Contato[] contatos = new Contato[10];
            Contato cc = new Contato();
            int escolha;
            do
            {
                Console.WriteLine("Digite Para Utilizar uma Função: \n" +
                    "1 - Adicionar Contato\n" +
                    "2 - Buscar Contato pelo Nome\n" +
                    "3 - Mostre Todos os contatos\n" +
                    "0 - Sair");
                escolha = Convert.ToInt32(Console.ReadLine());
                switch (escolha)
                {
                    case 1:
                        
                        cc = new Contato();
                        Console.WriteLine("Digite o Nome do Contato");
                        cc.setNome(Console.ReadLine());
                        Console.WriteLine("Digite a Idade do Contato");
                        cc.setIdade(Convert.ToInt32(Console.ReadLine()));
                        Console.WriteLine("Digite o Numero Do Contato");
                        cc.setNumero(Convert.ToInt32(Console.ReadLine()));
                        contatos[id] = cc;
                        id++;
                        Console.ReadKey();
                        break;
                    case 2:
                        string busca;
                        Console.WriteLine("Digite o Contato que Deseja buscar");
                        busca = Console.ReadLine();
                        int status = 0;
                        for (int i = 0; i < id; i++)
                        {
                            status = 1;
                            if (busca.Equals(contatos[id].getNome()))
                            {
                                Console.WriteLine($"Nome: {contatos[i].getNome()}" +
                                    $"\nIdade: {contatos[i].getIdade()}" +
                                    $"\nNúmero: {contatos[i].getNumero()}");
                            }
                        }
                        if (status == 0) Console.WriteLine("Contato não encontrado!");
                        Console.ReadKey();
                        break;
                    case 3:
                        for (int i = 0; i < 10; i++)
                        {
                            Console.WriteLine($"Nome: {contatos[i].getNome()}" +
                                   $"\nIdade: {contatos[i].getIdade()}" +
                                   $"\nNúmero: {contatos[i].getNumero()}\n\n");
                            Console.ReadKey();

                        }
                        break;

                }
            }
            while (escolha != 0);
                
        }
    }
}

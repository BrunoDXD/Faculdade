using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO3._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int op, cont = 0;
            Conta[] contas = new Conta[10];
            Conta cc = new Conta();

            Console.WriteLine("Informe a opção: \n" +
                "1 - Abrir uma conta bancária \n" +
                "2 - Consultar Saldo \n" +
                "3 - Sacar \n" +
                "4 - Depositar \n");
            op = Convert.ToInt32(Console.ReadLine());

            do
            {
                switch (op)
                {
                    case 1:
                        cc = new Conta();
                        Console.WriteLine("Informe o nome do Correntista");
                        cc.setNome(Console.ReadLine());
                        Console.WriteLine("Informe o CPF");
                        cc.setCpf(Console.ReadLine());
                        Console.WriteLine("Saldo de entrada");
                        cc.setSaldo(Convert.ToDouble(Console.ReadLine()));
                        contas[cont] = cc;
                        cont++;
                        break;

                    case 2:
                        Console.WriteLine("Informe o CPF: ");
                        string cpf = Console.ReadLine();
                        int status = 0;
                        for (int i = 0; i < cont; i++)
                        {
                            if (cpf.Equals(contas[i].getCpf()))
                            {
                                status = 1;
                                Console.WriteLine($"Titular da conta: {contas[i].getNome()}" +
                                    $"\nCPF: {contas[i].getCpf()}\nSaldo: {contas[i].getSaldo()}");
                                Console.ReadKey();
                            }
                        }
                        if (status == 0) Console.WriteLine("CPF não encontrado");
                        break;

                    case 3:
                        Console.WriteLine("Informe o CPF: ");
                        cpf = Console.ReadLine();
                        status = 0;
                        for (int i = 0; i < cont; i++)
                        {
                            if (cpf.Equals(contas[i].getCpf()))
                            {
                                status = 1;
                                Console.WriteLine("Informe o valor que deseja sacar");
                                if (!contas[i].sacar(Convert.ToDouble(Console.ReadLine())))
                                {
                                    Console.WriteLine("Saldo Insulficiente");
                                    Console.ReadKey();
                                }
                            }
                        }
                        if (status == 0) Console.WriteLine("CPF não encontrado");

                        break;

                    case 4:
                        Console.WriteLine("Informe o CPF: ");
                        cpf = Console.ReadLine();
                        status = 0;
                        for (int i = 0; i < cont; i++)
                        {
                            if (cpf.Equals(contas[i].getCpf()))
                            {
                                status = 1;
                                Console.WriteLine("Informe o valor que deseja Depositar: ");
                                contas[i].depositar(Convert.ToDouble(Console.ReadLine()));
                                Console.ReadKey();
                            }
                        }
                        if (status == 0) Console.WriteLine("CPF não encontrado");

                        break;
                        default:
                        Console.WriteLine("Operação inexistente!");
                        Console.ReadKey();
                        break;

                }
                Console.Clear();
                Console.WriteLine("Informe a opção: \n" +
                "1 - Abrir uma conta bancária \n" +
                "2 - Consultar Saldo \n" +
                "3 - Sacar \n" +
                "4 - Depositar \n" +
                "0 - Sair");
                op = Convert.ToInt32(Console.ReadLine());
            } while (op != 0);
            Console.ReadKey();
        }
    }
}

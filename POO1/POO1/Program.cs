using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaração e instanciação de objetos
            Veiculo carro = new Veiculo();

            Console.Write("Digite a Marca: ");
            string ma = Console.ReadLine();
            Console.Write("Digite a Modelo: ");
            string md = Console.ReadLine();
            Console.Write("Digite a chassis: ");
            string ch = Console.ReadLine();
            Console.Write("Digite a cor: ");
            string co = Console.ReadLine();
            Console.Write("Digite a ano: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite a Motor: ");
            double mt = Convert.ToDouble(Console.ReadLine());
            carro.receber(md, ma, ch, co, a, mt);

            Cliente pessoa = new Cliente();

            Console.Write("\n\nDigite o nome do Cliente: ");
            string nome = Console.ReadLine();
            Console.Write("Digite o CPF do Cliente: ");
            string cpf = Console.ReadLine();
            Console.Write("Digite o endereço do Cliente: ");
            string end = Console.ReadLine();
            Console.Write("Digite o telefone do Cliente: ");
            string cel = Console.ReadLine();
            pessoa.atribuir(nome, cpf, end, cel);

            Console.WriteLine("\nDados do Cliente");
            Console.WriteLine(pessoa.retornar());
            Console.WriteLine("\nDados do Carro");
            Console.WriteLine("\n"+carro.retorna());
            Console.ReadKey();
        }
    }
}

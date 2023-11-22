using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_3_Polimorfismo_
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public  int Matricula { get; set; }
        public double Salario { get; set; }

        public string MostrarDados()
        {
            return ($"Matricula: {Matricula} \nNome: {Nome}" +
                $"\nSalário: {Salario}");
        }

        public string MostrarDados(double valor)
        {
            return ($"Matricula: {Matricula} \nNome: {Nome}" +
                $"\nSalário: {Salario+valor}");
        }
    }
}

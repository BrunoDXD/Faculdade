using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_3_Polimorfismo_
{
    public class Vendedor : Funcionario
    {
        public double  ValorVenda{ get; set; }

        public string MostrarDados(double valor)
        {
            return ($"Matricula: {Matricula} \nNome: {Nome}" +
                $"\nSalário: {Salario + valor*0.1}\nTotal de Vendas: {ValorVenda}");
        }
    }
}

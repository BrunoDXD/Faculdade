using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_2_Resolução_
{
    public class Ingresso
    {
        public double valor;
        public Ingresso(double v)
        {
            this.valor = v;
        }
        public string toString()
        {
            return $"Valor do Ingresso ={this.valor.ToString("C")}";
        }
    }
}

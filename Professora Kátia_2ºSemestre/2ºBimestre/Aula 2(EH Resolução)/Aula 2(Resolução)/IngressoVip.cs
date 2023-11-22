using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_2_Resolução_
{
    public class IngressoVip : Ingresso
    {
        double adicional;
        public IngressoVip(double v, double a) : base (v)
        {
            this.adicional = a;
            
        }
        public string calcular()
        {
            return "Valor a Pagar: "+valor.ToString("C") + this.adicional;
        }
    }
}

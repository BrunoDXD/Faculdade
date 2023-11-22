using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_2_Exercicio_herança_
{
    internal class IngressoVip : Ingresso
    {
        public int ValorVip { get; set; }
        
        public IngressoVip()
        {
            ValorVip = ValorIngresso + 10;
        }
    }
}

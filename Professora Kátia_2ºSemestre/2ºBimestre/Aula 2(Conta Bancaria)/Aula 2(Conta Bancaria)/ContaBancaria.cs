using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_2_Conta_Bancaria_
{
    public class ContaBancaria
    {
         public string cliente { get; set; }
         public int numconta { get; set; }
         public string saldo { get; set; }


       
        public string Depositar()
        {
            return $"Total saldo após depósito: {this.saldo}";
        }
    }
}

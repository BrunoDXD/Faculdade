using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_2_Conta_Bancaria_
{
    public class ContaEspecial : ContaBancaria
    {
        double limite;
        double totalsaldo;
        

        public string Sacar()
        {
            return $"Saldo final após saque: {totalsaldo}";
        }
    }
}

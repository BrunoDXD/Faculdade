using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_2_Conta_Bancaria_
{
    public class ContaPoupanca : ContaBancaria
    {
        double rendiario, totsaldo;
        
        
        public double redi { get; set; }
        public string CalcularNovoSaldo()
        {
            return $"Novo saldo após o rendimento: {this.totsaldo += this.rendiario}";
        }

    }
}

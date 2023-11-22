using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula9
{
    public class Juridica : Pessoa
    {
        public Juridica(string n, string e, string t, string c)
            :base(n, e, t)
        {
            Cnpj = c;
        }

        public string Cnpj { get; set; }
    }
}

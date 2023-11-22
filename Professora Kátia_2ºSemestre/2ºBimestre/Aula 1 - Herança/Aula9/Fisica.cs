using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula9
{
    public class Fisica : Pessoa
    {
        public string Cpf { get; set; }
        
        public Fisica(string n, string e, string t, string c) 
            : base(n, e, t)
        {
            Cpf = c;
        }
    }
}

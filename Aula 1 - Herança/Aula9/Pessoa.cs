using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula9
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }

        public Pessoa(string n, string e, string t) {
            Nome = n;
            Endereco = e;
            Telefone = t;
        }
    }
}

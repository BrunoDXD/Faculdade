using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO8._0_List_
{
    internal class Produto
    {
        public int Codigo { get; set; }
        public string Descricao { get; set; }
        public double Preco { get; set; }

        public Produto(int codigo, string descricao, double preco)
        {
            Codigo = codigo;
            Descricao = descricao;
            Preco = preco;
        }
    }
}

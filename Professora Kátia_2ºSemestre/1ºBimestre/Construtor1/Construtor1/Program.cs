using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Construtor1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Application.Run(new FormAluno());
            

            //Curso curso = new Curso("ADS");
            //Console.WriteLine(curso.getNome()+" - "+curso.getPeriodo());

            Console.ReadKey();

        }
    }
}

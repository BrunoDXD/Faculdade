using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO1
{
    internal class Veiculo
    {
        //declaração dos atributos
        string modelo, marca, chassis, cor;
        int ano;
        double motor;

        //métodos
        public void receber(string mod, string mar, string ch, string c, int a, double mo)
        {
            this.modelo = mod;
            this.marca = mar;
            this.chassis = ch;
            this.cor = c;
            this.motor = mo;
            this.ano = a;

        }

        public string retorna()
        {
            string texto = "Marca = " + this.marca + "\tModelo = " + this.modelo + "\tChassis = "
                + this.chassis + "\nCor = " + this.cor + "\tMotor = " + this.motor + "\tAno = " + this.ano;
            return texto;
        }
    }
}

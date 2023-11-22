using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string numero = "";
        Candidato alguem;
        List<Candidato> candidatos = new List<Candidato>();
        int branco = 0, nulo = 0;

        private void insereCandidato()
        {
            alguem = new Candidato("Antonio Silva", "Sol", "Antonio.jpg", 12, 0);
            candidatos.Add(alguem);
            alguem = new Candidato("Joana Lima", "Nuvem", "Joana.jpg", 15, 0);
            candidatos.Add(alguem);
            alguem = new Candidato("Vivian", "Lua", "Vivian.jpg", 21, 0);
            candidatos.Add(alguem);
            alguem = new Candidato("Frederico Ferreira", "Raio", "Frederico.jpg", 29, 0);
            candidatos.Add(alguem);
        }

        private void btnbranco_Click(object sender, EventArgs e)
        {
            numero = "branco";
            btnconfirmar.Enabled = true;
            lbnome.Text = "VOTO EM BRANCO";
        }

        private void preencher(string n)
        {
            SoundPlayer som = new SoundPlayer(
                @"E:\PastaSegura\Trabalhos\Katia_2º_Semestre\Aula6\Aula6\som\Tecla.wav"
            );
            som.Play();
            numero += n;
            if (numero.Equals("00"))
            {
                string texto = "";
                for( int i = 0; i < candidatos.Count; i++)
                {
                    texto += "\n" + candidatos[i].getNome() + ": " +
                        candidatos[i].getVoto();
                }
                texto += "\nNulo: " + nulo + "\nBranco: " + branco;
                MessageBox.Show(texto);
            }
            if (numero.Length == 1)
            {
                txt1.Text = n;
            }
            if (numero.Length == 2)
            {
                txt2.Text = n;
                int valido = 0;
                
                for (int i=0; i<candidatos.Count; i++)
                {
                    if (candidatos[i].getNumero() == Convert.ToInt32(numero))
                    {
                        pbxfoto.Image = System.Drawing.Image.FromFile(
                            @"E:\PastaSegura\Trabalhos\Katia_2º_Semestre\Aula6\Aula6\fotos\" +
                            candidatos[i].getFoto());
                        lbnome.Text = candidatos[i].getNome();
                        lbchapa.Text = candidatos[i].getChapa();
                        btnconfirmar.Enabled = true;
                        valido = 1;
                    }
                }
                if (valido == 0)
                {
                    lbnome.Text = "VOTO NULO";
                    btnconfirmar.Enabled = true;
                }

            }
            
        }

        private void btncorrigir_Click(object sender, EventArgs e)
        {
            txt1.Text = null;
            txt2.Text = null;
            pbxfoto.Image = null;
            numero = "";
            lbnome.Text = null;
            lbchapa.Text = null;
            btnconfirmar.Enabled = false;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            preencher("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            preencher("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            preencher("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            preencher("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            preencher("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            preencher("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            preencher("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            preencher("8");
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            preencher("0");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            preencher("9");
        }

        private void btnconfirmar_Click(object sender, EventArgs e)
        {
            SoundPlayer som = new SoundPlayer(
                @"E:\PastaSegura\Trabalhos\Katia_2º_Semestre\Aula6\Aula6\som\urna.wav"
                );
            som.Play();
            int existir = 0;

            if (numero.Equals("branco")) {
                branco++;
            } else{
                for (int i = 0; i < candidatos.Count; i++) {
                        if (Convert.ToInt32(numero) == candidatos[i].getNumero()){
                            candidatos[i].setVoto(candidatos[i].getVoto() + 1);
                            existir = 1;
                        }
                }
                if (existir == 0)
                {
                    nulo++;
                }
            }
            btncorrigir_Click(sender, e);
        }

       
        

        private void Form1_Load(object sender, EventArgs e)
        {
            insereCandidato();
            txt1.Enabled = false;
            txt2.Enabled = false;
            btnconfirmar.Enabled = false;
        }
    }
}

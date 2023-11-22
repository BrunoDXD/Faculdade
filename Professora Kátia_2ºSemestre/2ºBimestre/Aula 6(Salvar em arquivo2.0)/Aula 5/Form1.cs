using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ContaCorrente cc = new ContaCorrente();
        Manipula arquivo = new Manipula();  

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btncriarconta_Click(object sender, EventArgs e)
        {
            cc.Agencia = txtagencia.Text;
            cc.NumConta = txtconta.Text;
            cc.Titular = txttitular.Text;
            cc.Saldo = Convert.ToDouble(txtsaldo.Text);
            cc.Limite=Convert.ToDouble(txtlimite.Text);
            MessageBox.Show("Conta criada com Sucesso!");
            arquivo.Gravar(cc.Agencia+";"+cc.NumConta+";"+
                cc.Titular+";"+cc.Saldo+";"+cc.Limite);

        }

        private void btndepositar_Click(object sender, EventArgs e)
        {
            cc.Depositar(Convert.ToDouble(txtvalor.Text));
            txtsaldo.Text = cc.Saldo.ToString();
            txtvalor.Text = "";
            arquivo.Alterar(cc);
        }

        private void btnsacar_Click(object sender, EventArgs e)
        {
            cc.sacar(Convert.ToDouble(txtvalor.Text));
            txtsaldo.Text = cc.Saldo.ToString();
            txtvalor.Text = "";
            arquivo.Alterar(cc);
        }

        private void btnexibir_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Agência: {cc.Agencia}\n" +
                $"Número da conta: {cc.NumConta}\n" +
                $"Titular: {cc.Titular}\n" +
                $"Saldo: {cc.Saldo}\n" +
                $"Limite: {cc.Limite}\n" +
                $"Valor Tributário: {cc.CalculaTributo()}");
        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            cc = new ContaCorrente();
            cc.NumConta = txtconta.Text;
            arquivo.Apagar(cc);
            MessageBox.Show("Excluído com sucesso!");
            txtconta.Text = "";

        }

        private void btnpesquisar_Click(object sender, EventArgs e)
        {
            cc = new ContaCorrente();
            cc.NumConta = txtconta.Text;
            ContaCorrente conta = new ContaCorrente();
            conta = arquivo.Pesquisar(cc);
            txtagencia.Text = conta.Agencia;
            txtsaldo.Text = conta.Saldo.ToString();
            txttitular.Text = conta.Titular;
            txtlimite.Text = conta.Limite.ToString();

        }
    }
}

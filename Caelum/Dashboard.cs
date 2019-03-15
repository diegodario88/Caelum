using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caelum
{
    public partial class Dashboard : Form
    {
        private Conta conta;

        public Dashboard()
        {
            InitializeComponent();
        }




        private void Dashboard_Load(object sender, EventArgs e)
        {

            //	Cria	uma	nova	conta	e	guarda	sua	referência	no	atributo	do	formulário
            this.conta = new Conta();
            this.conta.Numero = 080074;
            Cliente cliente = new Cliente("Victor José Ferreira");
            this.conta.Titular = cliente.Nome;
            textoTitular.Text = conta.Titular;
            textoNumero.Text = Convert.ToString(conta.Numero);
            textoSaldo.Text = Convert.ToString(conta.Saldo);

        }
        private void btnDeposito_Click(object sender, EventArgs e)
        {
            string valorDigitado = textoValor.Text;
            double valorOperacao = Convert.ToDouble(valorDigitado);
            this.conta.Deposita(valorOperacao);
            textoSaldo.Text = Convert.ToString(this.conta.Saldo);
            MessageBox.Show("Transação feita com sucesso ");



        }

        private void btnSaque_Click(object sender, EventArgs e)
        {
            string valorDigitado = textoValor.Text;
            double valor = Convert.ToDouble(valorDigitado);
            if (this.conta.Sacar(valor))
            {
                textoSaldo.Text = Convert.ToString(valor);
                MessageBox.Show("Transação feita com sucesso ");
            }
            else
            {
                MessageBox.Show("Transação não permitida");
            }
        }
    }
}

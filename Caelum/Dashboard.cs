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
            this.conta = new ContaPoupanca();
            this.conta.Numero = 080074;
            this.conta.Tipo = 1;

            // Cria um cliente com os parâmetros necessários do construtor
            Cliente cliente = new Cliente("Victor José Ferreira", 19, "123456789", "Maior");

            // Pega o nome do cliente e poe como Titular da Conta
            this.conta.Titular = cliente;
            textoTitular.Text = cliente.Nome;
            // Converte e exibe número e saldo nos campos
            textoNumero.Text = Convert.ToString(conta.Numero);
            textoSaldo.Text = Convert.ToString(conta.Saldo);

            if (this.conta.Tipo == 1)
            {
                lblTipo.Text = "Conta Poupança" + "\n" + "Saques serão cobrados";
            }
            else
            {
                lblTipo.Text = "Conta Corrente";
            }




        }
        // Ação do botão Depósito
        private void btnDeposito_Click(object sender, EventArgs e)
        {
            string valorDigitado = textoValor.Text;
            double valorOperacao = Convert.ToDouble(valorDigitado);
            this.conta.Deposita(valorOperacao);
            textoSaldo.Text = Convert.ToString(this.conta.Saldo);
            MessageBox.Show("Transação feita com sucesso ");



        }
        // Ação do botão Saque
        private void btnSaque_Click(object sender, EventArgs e)
        {
            string valorDigitado = textoValor.Text;
            double valor = Convert.ToDouble(valorDigitado);
            if (this.conta.Sacar(valor))
            {
                textoSaldo.Text = Convert.ToString(this.conta.Saldo);
                MessageBox.Show("Transação feita com sucesso ");
            }
            else
            {
                MessageBox.Show("Transação não permitida");
            }
        }
    }
}

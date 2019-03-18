using System;
using System.Windows.Forms;

namespace Caelum
{
    public partial class Dashboard : Form
    {
        private Conta[] contas;

        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)

        {

            //	Cria um array de contas e poe um cliente como titular
            this.contas = new Conta[3];
            this.contas[0] = new Conta(100, 2);
            Cliente cliente = new Cliente("Victor José Ferreira", 19, "123456789", "Maior");
            this.contas[0].Titular = cliente;

            this.contas[1] = new ContaCorrente(200, 2);
            Cliente cliente1 = new Cliente("Jorge Henrique", 15, "1231313", "Emancipado");
            this.contas[1].Titular = cliente1;

            this.contas[2] = new ContaPoupanca(300, 1);
            Cliente cliente2 = new Cliente("João das Couves", 77, "1231", "Maior");
            this.contas[2].Titular = cliente2;


            foreach(Conta conta in contas)
            {
                comboContas.Items.Add(conta.Titular.Nome);
            }
            
            // Totalizador
            TotalizadorDeContas t = new TotalizadorDeContas();



        }
                             
        // Ação do botão Depósito
        private void btnDeposito_Click(object sender, EventArgs e)
        {
            string valorDigitado = textoValor.Text;
            double valorOperacao = Convert.ToDouble(valorDigitado);

            //Recupera o Índice digitado 
            int indice = comboContas.SelectedIndex;

            //lê a posição correta do array 
            Conta selecionada = this.contas[indice];


            selecionada.Deposita(valorOperacao);
            textoSaldo.Text = Convert.ToString(selecionada.Saldo);
            MessageBox.Show("Transação feita com sucesso ");



        }
        // Ação do botão Saque
        private void btnSaque_Click(object sender, EventArgs e)
        {
            string valorDigitado = textoValor.Text;
            double valor = Convert.ToDouble(valorDigitado);
            int indice = comboContas.SelectedIndex;
            Conta selecionada = this.contas[indice];
            if (selecionada.Sacar(valor))
            {
                textoSaldo.Text = Convert.ToString(selecionada.Saldo);
                MessageBox.Show("Transação feita com sucesso ");
            }
            else
            {
                MessageBox.Show("Transação não permitida");
            }
        }

        private void comboContas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = comboContas.SelectedIndex;
            Conta selecionada = this.contas[indice];
            if (selecionada.Tipo == 1)
            {
                lblTipo.Text = "Conta Poupança" + "\n" + "Serão cobrados R$ 0,10 em cada saque";
            }
            else
            {
                lblTipo.Text = "Conta Corrente" + "\n" + "Serão cobrados R$ 0,10 em cada depósito." + "\n" + "R$ 0,05 em saques.";
            }
            textoNumero.Text = Convert.ToString(selecionada.Numero);
            textoTitular.Text = selecionada.Titular.Nome;
            textoSaldo.Text = Convert.ToString(selecionada.Saldo);
        }
    }
}

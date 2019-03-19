using System;
using System.Windows.Forms;

namespace Caelum
{
    public partial class Dashboard : Form
    {
        private Conta[] contas;
        private int numeroContas;
        
        public Dashboard()
        {
            InitializeComponent();
        }
        // Método Adicina Nova Conta
        public void AdicionaConta(Conta conta)
        {
            
                this.contas = new Conta[3+numeroContas];
                this.contas[this.numeroContas] = conta;
                this.numeroContas++;
                comboContas.Items.Add(conta.Titular.Nome);
                comboDestinoTransferencia.Items.Add(conta.Titular.Nome);
            

        }
        private void Dashboard_Load(object sender, EventArgs e)

        {

            //	Cria um array de contas e poe um cliente como titular
            

            Conta c1 = new Conta(100, 2);
            Cliente cliente = new Cliente("Maria das Dores", 19, "123456789", "Maior");
            c1.Titular = cliente;
            this.AdicionaConta(c1);

            Conta c2 = new ContaCorrente(200, 2);
            Cliente cliente1 = new Cliente("Juca dos Prazeres", 15, "1231313", "Emancipado");
            c2.Titular = cliente1;
            this.AdicionaConta(c2);

            Conta c3 = new ContaPoupanca(300, 1);
            Cliente cliente2 = new Cliente("João das Couves", 77, "1231", "Maior");
            c3.Titular = cliente2;
            this.AdicionaConta(c3);


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
        // Ação do comboboxContas
        private void comboContas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = comboContas.SelectedIndex;
            Conta selecionada = this.contas[indice];
            if (selecionada.Tipo == 1)
            {
                lblTipo.Text = "Conta Poupança" + "\n" + "Taxa fixa de movimentação" + "\n" + "R$ 0,10 ";
            }
            else
            {
                lblTipo.Text = "Conta Corrente" + "\n" + "Serão cobrados R$ 0,10 em cada depósito." + "\n" + "R$ 0,05 em saques.";
            }

            textoNumero.Text = Convert.ToString(selecionada.Numero);
            textoTitular.Text = selecionada.Titular.Nome;
            textoSaldo.Text = Convert.ToString(selecionada.Saldo);
        }
        // Ação do comboBoxTransferência
        private void comboDestinoTransferencia_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = comboDestinoTransferencia.SelectedIndex;
            Conta selecinada = this.contas[indice];

        }
        // Ação Botão Nova Conta
        private void btnNovaConta_Click(object sender, EventArgs e)
        {
            FormCadastroContas formularioDeCadastro = new FormCadastroContas(this);
            formularioDeCadastro.ShowDialog();
        }
        // Ação Botão Transferir
        private void btnTransferencia_Click(object sender, EventArgs e)
        {
            string valorDigitado = textoValor.Text;
            double valorOperacao = Convert.ToDouble(valorDigitado);
            int indiceOrigem = comboContas.SelectedIndex;
            int indiceDestino = comboDestinoTransferencia.SelectedIndex;
            Conta selecionadaOrigem = this.contas[indiceOrigem];
            Conta selecionadaDestino = this.contas[indiceDestino];
            selecionadaOrigem.Transfere(valorOperacao, selecionadaDestino);
        }
    }
}

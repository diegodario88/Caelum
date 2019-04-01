using System;
using System.Windows.Forms;

namespace Caelum
{
    public partial class FormCadastroContas : Form

    {
        private Dashboard formPrincipal;


        public FormCadastroContas(Dashboard formPrincipal)
        {
            this.formPrincipal = formPrincipal;
            InitializeComponent();


        }
        // Ação botão Cadastrar
        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            int tipo;
            

            if (comboTipoConta.SelectedIndex <= 0)
            {
                tipo = 1;
                Conta novaConta = new ContaPoupanca(Conta.ProximaConta(),tipo);
                novaConta.Titular = new Cliente(textoTitular.Text);
                novaConta.Numero = Convert.ToInt32(textoNumero.Text);
                this.formPrincipal.AdicionaConta(novaConta);
            }
            else
            {
                tipo = 2;
                Conta novaConta = new ContaCorrente(Conta.ProximaConta(), tipo);
                novaConta.Titular = new Cliente(textoTitular.Text);
                novaConta.Numero = Convert.ToInt32(textoNumero.Text);
                this.formPrincipal.AdicionaConta(novaConta);
            }

            //Limpa os campos
            textoNumero.Text = Convert.ToString(Conta.ProximaConta());
            textoTitular.Text = "";
            comboTipoConta.Text = "";


        }
        //Formata campo Número da conta
        private void FormCadastroContas_Load(object sender, EventArgs e)
        {
            textoNumero.Text = Convert.ToString(Conta.ProximaConta());
        }
    }
}

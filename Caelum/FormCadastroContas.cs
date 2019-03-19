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
            int numero, tipo;
            numero = Convert.ToInt32(textoNumero.Text);


            if (comboTipoConta.SelectedIndex <= 0)
            {
                tipo = 1;
                Conta novaConta = new ContaPoupanca(numero, tipo);
                novaConta.Titular = new Cliente(textoTitular.Text);
                novaConta.Numero = Convert.ToInt32(textoNumero.Text);
                this.formPrincipal.AdicionaConta(novaConta);
            }
            else
            {
                tipo = 2;
                Conta novaConta = new ContaCorrente(numero, tipo);
                novaConta.Titular = new Cliente(textoTitular.Text);
                novaConta.Numero = Convert.ToInt32(textoNumero.Text);
                this.formPrincipal.AdicionaConta(novaConta);
            }



        }

    }
}

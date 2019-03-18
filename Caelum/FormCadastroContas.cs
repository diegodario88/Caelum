using System;
using System.Windows.Forms;

namespace Caelum
{
    public partial class FormCadastroContas : Form
        
    {
        private Dashboard formPrincipal;

        public FormCadastroContas(Dashboard formPrincipal )
        {
            this.formPrincipal = formPrincipal;
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Conta novaConta = new ContaCorrente(400, 2);
            novaConta.Titular = new Cliente(textoTitular.Text);
            novaConta.Numero = Convert.ToInt32(textoNumero.Text);
        }
    }
}

namespace Caelum
{
    class ContaCorrente : Conta
    {
        public ContaCorrente (int numero, int tipo) : base (numero, tipo) {}
        public override bool Sacar(double valor) => base.Sacar(valor + 0.5);
        public override void Deposita(double valor)
        {
            base.Deposita(valor - 0.10 );
        }

    }
}

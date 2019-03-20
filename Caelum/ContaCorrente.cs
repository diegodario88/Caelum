namespace Caelum
{
    class ContaCorrente : Conta
    {
        public ContaCorrente(int numero, int tipo) : base(numero, tipo) { } //Construtor

        public override bool Sacar(double valor) //Implementa Sacar
        {
            
                if (this.Saldo >= valor)
                {
                    this.Saldo -= valor;

                    return true;
                }
                return false;
            
        }

        public override void Deposita(double valor) //Implementa Deposita
        {
            this.Saldo += (valor - 0.10 );
        }

    }
}

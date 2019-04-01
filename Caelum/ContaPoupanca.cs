namespace Caelum
{
    class ContaPoupanca : Conta, ITributavel
    {
        public ContaPoupanca(int numero, int tipo) : base(numero, tipo) { } //Construtor

        public override bool Sacar(double valor) //Implementa Sacar
        {
            {
                if (this.Saldo >= valor)
                {
                    this.Saldo -= (valor + 0.10);

                    return true;
                }
                return false;
            }
        }

        public override void Deposita(double valor) //Implementa Deposita
        {
            this.Saldo += valor;
        }

        public double CalculaTributo()
        {
            return this.Saldo * 0.02;
        }

    }
}

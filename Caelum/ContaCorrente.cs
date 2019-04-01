namespace Caelum
{
    class ContaCorrente : Conta, ITributavel
    {
        public static int ProximaConta()
        {
            return ContaCorrente.totalDeContas + 1;
        }
        private static int totalDeContas = 0;
                
        public ContaCorrente(int numero, int tipo) : base(numero, tipo) { ContaCorrente.totalDeContas++;} //Construtor
        
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

        public double CalculaTributo() //Implementa Interface
        {
            return this.Saldo * 0.05;
        }

    }
}

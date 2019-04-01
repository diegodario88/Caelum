namespace Caelum
{
    class TotalizadorDeContas
    {
        public double ValorTotal { get; private set; }
        

        public void Soma (Conta conta)
        {
            ValorTotal += conta.Saldo;
        }
            
    }
}

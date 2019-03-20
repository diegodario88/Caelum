namespace Caelum
{
   public abstract class Conta
    {

        // Declaração Variável com a propriedade
        public int Numero { get; set; }
        public double Saldo { get; protected set; }
        public Cliente Titular { get; set; }
        public int Tipo { get; set; }

        
       // Construtor com argumento
       public Conta (int numero, int tipo)
        {
            this.Tipo = tipo;
            this.Numero = numero;
        }
       
        // Método para depositar um valor
        abstract public void Deposita(double valor);
        
        // Método para Sacar 
        abstract public bool Sacar(double valor);
       
        // Método para transferir valor se atender o requisito testado no método Sacar
        public void Transfere(double valor, Conta destino)
        {
            if (this.Sacar(valor))
            {
                destino.Deposita(valor);
            }
        }

              
    }

}

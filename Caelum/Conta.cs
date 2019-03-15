using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caelum
{
    public class Conta
    {

        // Declaração Variável com a propriedade
        public int Numero { get; set; }
        public double Saldo { get; private set; }
        public Cliente Titular { get; set; }
        public int Tipo { get; set; }

       
        // Método para depositar um valor
        public void Deposita(double valor)
        {
            this.Saldo += valor;

        }

        // Método para Sacar valor se atender a condição ele verifica o tipo da conta para cobrar taxa 
        public virtual bool Sacar(double valor)
        {
            if (this.Saldo >= valor)
            {
                this.Saldo -= valor;
                
                return true;
            }
            return false;
        }
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caelum
{
    public class Conta
    {

        //Declaração Variável com a propriedade
        public int Numero { get; set; }
        public double Saldo { get; private set; }
        public string Titular { get; set; }

        public Conta()
        {

        }
        public void Deposita(double valor)
        {
            this.Saldo += valor;

        }

        public bool Sacar(double valor)
        {
            if (this.Saldo >= valor)
            {
                Saldo -= valor;
                return true;
            }
            return false;
        }
        public void Transfere(double valor, Conta destino)
        {
            if (this.Sacar(valor))
            {
                destino.Deposita(valor);
            }
        }
    }

}

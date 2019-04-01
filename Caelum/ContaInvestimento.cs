using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caelum
{
    class ContaInvestimento : Conta, ITributavel
    {
        public ContaInvestimento(int numero, int tipo) : base(numero, tipo) { }

        public double CalculaTributo()
        {
            return this.Saldo * 0.03;
        } //Implementa a Interface

        public override void Deposita(double valor)
        {
            Saldo += valor;    
        } //Implementa Método Abstrato

        public override bool Sacar(double valor)
        {
            throw new NotImplementedException();
        } //Implementa Método Abstrato

    }

}

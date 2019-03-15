using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caelum
{
    class ContaPoupanca : Conta
    { // Utiliza a herança da conta base e retorna o valor com a taxa de saque da poupança
        public override bool Sacar(double valor) => base.Sacar(valor + 0.10); 

    }
}

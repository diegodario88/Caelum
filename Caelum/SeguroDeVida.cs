using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caelum 
{
    class SeguroDeVida : ITributavel
    {
        public double CalculaTributo() //Implementa Interface
        {
            double valorSeguro = 42;
            return valorSeguro;
        }
    }
}

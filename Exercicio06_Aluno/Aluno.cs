using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio06_Aluno
{
    internal class Aluno
    {
        public string Nome;
        public double PrimeiroS;
        public double SegundoS;
        public double TerceiroS;

        public double NotaFinal()
        {
            return PrimeiroS + SegundoS + TerceiroS;
        }
    }
}

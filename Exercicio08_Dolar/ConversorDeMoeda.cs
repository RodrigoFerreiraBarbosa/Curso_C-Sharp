using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio08_Dolar
{
    internal class ConversorDeMoeda
    {
        public static double Cotacao;
        public static double Dolar;
        public static double Iof()
        {
            return (Cotacao * 6) / 100;
        }

        public static double Conversor()
        {
            return Dolar * (Cotacao  + Iof());  
        }
    }
}

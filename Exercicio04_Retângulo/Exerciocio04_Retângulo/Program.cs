using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exerciocio04_Retângulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Retangulo ret = new Retangulo();
            Console.WriteLine("Entre com a largura e a altura do retângulo: ");
            ret.Largura = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            ret.Altura = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine("Area: " + ret.Area().ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("Perimetro: " + ret.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Diagonal: " + ret.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
            

        }
    }
}

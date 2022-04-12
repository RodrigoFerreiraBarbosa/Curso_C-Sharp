using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercicio02_Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dados nome, salario, nome2, salario2;

            nome = new Dados();
            salario = new Dados();
            nome2 = new Dados();
            salario2 = new Dados();

            Console.Write("Entre com o nome do primeiro funcionario :");
            nome.Nome = Console.ReadLine();
            Console.Write("Entre com o salario :");
            salario.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("\nEntre com o nome do segundo funcionario :");
            nome2.Nome = Console.ReadLine();
            Console.Write("Entre com o salario :");
            salario2.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("\nDados do primeiro funcionario :\n Nome:{0}\n Salario:{1}",nome.Nome , salario.Salario);
            Console.WriteLine("\nDados do segundo funcionario :\n Nome:{0}\n Salario:{1}",nome2.Nome, salario2.Salario);

            double media = (salario.Salario + salario2.Salario) / 2;
            Console.WriteLine("Salario medio:" + media,CultureInfo.InvariantCulture);
        }
    }
}

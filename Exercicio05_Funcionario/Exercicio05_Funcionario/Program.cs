using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercicio05_Funcionario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario func = new Funcionario();
            Console.Write("Nome: ");
            func.Nome = Console.ReadLine();
            Console.Write("Sálario Bruto: ");
            func.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            func.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine("Funcionário: " + func);

            Console.WriteLine();
            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double por = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            func.AumentarSalario(por);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + func);
            
        }
    }
}

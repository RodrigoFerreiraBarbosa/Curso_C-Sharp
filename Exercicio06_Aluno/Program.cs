using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercicio06_Aluno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();

            Console.Write("Nome do aluno: ");
            aluno.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno: ");
            aluno.PrimeiroS = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.SegundoS = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);  
            aluno.TerceiroS = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double NotaF = aluno.NotaFinal();

            Console.WriteLine("Nota final: " + NotaF.ToString("F2", CultureInfo.InvariantCulture));
            if(NotaF >= 60.00)
            {
                Console.WriteLine("Aprovado");
            }
            else
            {
                Console.WriteLine("Reprovado");
                NotaF = aluno.NotaFinal() - 60.00;
                Console.WriteLine("Faltaram:" + NotaF.ToString("F2", CultureInfo.InvariantCulture)+" Pontos");
            }

        }
    }
}

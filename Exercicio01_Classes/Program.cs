using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01_Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dados nome, idade, nome2, idade2;

            nome = new Dados();
            idade = new Dados();
            nome2 = new Dados();
            idade2 = new Dados();

            Console.Write("Entre com o primeiro nome da pessoa :");
            nome.Nome = Console.ReadLine();
            Console.Write("Entre com a idade da primeira pessoa :");
            idade.Idade = int.Parse(Console.ReadLine());

            Console.Write("\nEntre com o segundo nome da pessoa :");
            nome2.Nome = Console.ReadLine();
            Console.Write("Entre com a idade da segundo pessoa :");
            idade2.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("\nDados da primeira pessoa :\nNome:{0}\nIdade:{1}" ,nome.Nome ,idade.Idade);
            Console.WriteLine("\nDados da segunda pessoa :\nNome:{0}\nIdade:{1}", nome2.Nome, idade2.Idade);

            if (idade.Idade > idade2.Idade)
            {
                Console.WriteLine("\nPessoa mais velha :" + nome.Nome);
            }
            else
            {
                Console.WriteLine("\nPessoa mais velha :" + nome2.Nome);
            }
        }
    }
}

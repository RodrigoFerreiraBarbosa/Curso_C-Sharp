using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercicio11_Banco
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com o numero da conta: ");
            int conta = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string nome = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)?: ");
            char escolha = char.Parse(Console.ReadLine());
            if(escolha == 's')
            {
                Console.Write("Entre o valor de depósito inicial: ");
                double primeiroD = double.Parse(Console.ReadLine());
                Banco banco = new Banco(conta, nome, primeiroD);

                Console.WriteLine("\nDados da conta:\n" + banco);

                Console.Write("\nEntre um valor para depósito: ");
                double deposito = double.Parse(Console.ReadLine());
                banco.Deposito(deposito);
                Console.WriteLine("\nDados da conta atualizados:\n" + banco);

                Console.Write("\nEntre um valor para saque: ");
                double saque = double.Parse(Console.ReadLine());
                banco.Saque(saque);
                Console.WriteLine("\nDados da conta atualizados:\n" + banco);

            }
            else if(escolha == 'n')
            {
                Banco banco = new Banco(conta, nome);

                Console.WriteLine("\nDados da conta:\n" + banco);

                Console.Write("\nEntre um valor para depósito: ");
                double deposito = double.Parse(Console.ReadLine());
                banco.Deposito(deposito);
                Console.WriteLine("\nDados da conta atualizados:\n" + banco);

                Console.Write("\nEntre um valor para saque: ");
                double saque = double.Parse(Console.ReadLine());
                banco.Saque(saque);
                Console.WriteLine("\nDados da conta atualizados:\n" + banco);

            }
            else
            {
                Console.WriteLine("Invalido");
            }

        }
    }
}

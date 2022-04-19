using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Exercicio11_Banco
{
    internal class Banco
    {
        public int Conta { get; private set; }
        public double Saldo { get; private set; }

        private string _nome;
        
        public Banco(int conta, string nome) { Conta = conta; _nome = nome; }
        public Banco(int conta, string nome, double saldo) { Conta = conta; _nome = nome; Saldo = saldo; }  

        public string Nome { get { return _nome; } set { if (value != null && value.Length > 1) { _nome = value; } } }

        public void Deposito(double deposito)
        {
            Saldo += deposito;
        }
        public void Saque(double saque)
        {
            if(Saldo > 0) {Saldo -= (saque + 5.00); }}

        public override string ToString()
        {
            return "Conta :" + Conta + ", Titulár: " + _nome + ", Saldo: R$ " + Saldo.ToString("F2",CultureInfo.InvariantCulture); 
        }
    }
}

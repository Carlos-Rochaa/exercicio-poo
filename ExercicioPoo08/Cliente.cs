using System;

using System.Globalization; 

namespace ExercicioPoo08
{
    internal class Cliente
    {
        public string Name {  get; set; } 
        public int Conta { get; private set; }
        public double Saldo { get; private set; } 

        public Cliente()
        {

        }

        public Cliente(string name, int conta, double depositoInicial) : this(name, conta)
        {

            Deposito(depositoInicial); 
        }

        public Cliente(string name, int conta)
        {
            Name = name;
            Conta = conta;
            Saldo = 0; 
        }

        public void Deposito(double valor)
        {
            Saldo += valor; 
        }

        public void Saque(double valor)
        {
            Saldo -= valor + 5; //taxa de 5$ para o saque. 
        }

        public void PrintInfo()
        {
            Console.WriteLine("Dados da conta: ");
            Console.Write("Conta " + Conta + ", Titular: " + Name + ", Saldo: $ " + Saldo.ToString("F2", CultureInfo.InvariantCulture));
        }

        public void PrintInfoUpdated()
        {
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine("Conta " + Conta + ", Titular: " + Name + ", Saldo: $ " + Saldo.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}

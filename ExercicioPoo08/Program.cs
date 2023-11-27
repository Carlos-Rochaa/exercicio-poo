using System;
using System.Globalization; 
namespace ExercicioPoo08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente; 
            Console.Write("Entre com o número da conta: "); 
            int numeroConta = int.Parse(Console.ReadLine());
            Console.Write("Entre o nome do titular da conta: ");
            string nomeTitular = Console.ReadLine();
            Console.Write("Haverá depósito inicial? (s/n): ");
            string resposta = Console.ReadLine();
            if (resposta == "s" || resposta == "S")
            {
                Console.Write("Entre o valor do depósito inicial: "); 
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                 cliente = new Cliente(nomeTitular, numeroConta, depositoInicial);
            }
            else
            {
                 cliente = new Cliente(nomeTitular, numeroConta); 
            }
             

            cliente.PrintInfo();
            Console.WriteLine();

            Console.Write("Entre um valor para depósito: "); 
            double valorDeposito = double.Parse(Console.ReadLine() , CultureInfo.InvariantCulture);
            cliente.Deposito(valorDeposito);
            Console.WriteLine(); 
            cliente.PrintInfoUpdated();

            Console.Write("Entre um valor para saque: ");
            double valorSaque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            cliente.Saque(valorSaque);
            Console.WriteLine();
            cliente.PrintInfoUpdated();



        }
    }
}

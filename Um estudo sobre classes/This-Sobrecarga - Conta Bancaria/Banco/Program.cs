using System;
using System.Globalization;

namespace Banco {
    class Program {
        static void Main(string[] args) {

            ContaBancaria c;
            CultureInfo CI = CultureInfo.InvariantCulture;
            
            Console.Write("Entre o número da conta: ");
            int numero = int.Parse(Console.ReadLine(), CI);
            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)? ");
            char decisao = char.Parse(Console.ReadLine());

            if (decisao == 's' || decisao == 'S') {
                Console.Write("Entre o valor de depósito inicial: ");
                double saldo = double.Parse(Console.ReadLine(), CI);
                c = new ContaBancaria(numero, titular, saldo);
            }
            else {
                c = new ContaBancaria(numero, titular);
            }            

            Console.WriteLine();
            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(c);

            Console.WriteLine();
            Console.Write("Entre um valor para depósito: ");
            double deposito = double.Parse(Console.ReadLine(), CI);
            c.Deposito(deposito);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(c);

            Console.WriteLine();
            Console.Write("Entre um valor para saque: ");
            double saque = double.Parse(Console.ReadLine(), CI);
            c.Saque(saque);
            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(c);
        }
    }
}
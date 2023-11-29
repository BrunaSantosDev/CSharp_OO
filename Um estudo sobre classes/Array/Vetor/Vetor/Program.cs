using System;
using System.Globalization;
using System.Numerics;

namespace Vetor {
    class Program {
        static void Main(string[] args) {            
            Console.Write("Quantos quartos serão alugados? ");
            int n = int.Parse(Console.ReadLine());

            Quarto[] vect = new Quarto[10];
            for (int i = 0; i < n; i++) {
                Console.WriteLine();
                Console.WriteLine("Aluguel #" + (i+1));
                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Email: ");
                string email = Console.ReadLine();

                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());

                vect[quarto] = new Quarto(nome, email);                
            }

            Console.WriteLine();
            Console.WriteLine("Quartos ocupados:");
            for (int i = 0; i < n; i++) {
                if (vect[i] != null) {
                    Console.WriteLine(i + ": " + vect[i]);
                }
            }            
        }
    }
}
using System;

class Dados {
    public string A;
    public int B;
}

namespace Atividade1 {
    class Program {
        static void Main(string[] args) {
            // O programa terá como entrada de dados 2 pessoas e mostrará como saída qual é a mais velha.

            Dados x, y;
            x = new Dados();
            y = new Dados();

            Console.WriteLine("Dados da primeira pessoa: ");
            Console.Write("Nome: ");
            x.A = Console.ReadLine();
            Console.Write("Idade: ");
            x.B = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa: ");
            Console.Write("Nome: ");
            y.A = Console.ReadLine();
            Console.Write("Idade: ");
            y.B = int.Parse(Console.ReadLine());

            if (x.B > y.B) {
                Console.WriteLine("Pessoa mais velha: " + x.A);
            }
            else
            {
                Console.WriteLine("Pessoa mais velha: " + y.A) ;
            }
        }
    }
}
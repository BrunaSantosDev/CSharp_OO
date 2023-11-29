using System;
using System.Globalization;

namespace Exercicio1 {
    class Program {
        static void Main(string[] args) {
            // O objetivo do código é calcular a largura e altura do retângulo.

            CultureInfo CI = CultureInfo.InvariantCulture;
            Retangulo x = new Retangulo();

            Console.WriteLine("Entre com a largura e altura do retâgulo:");
            x.Largura = double.Parse(Console.ReadLine(), CI);
            x.Altura = double.Parse(Console.ReadLine(), CI);

            Console.WriteLine("AREA = " + x.Area().ToString("F2", CI));
            Console.WriteLine("PERÍMETRO = " + x.Perimetro().ToString("F2", CI));
            Console.WriteLine("DIAGONAL = " + x.Diagonal().ToString("F2", CI));
        }
    }
}
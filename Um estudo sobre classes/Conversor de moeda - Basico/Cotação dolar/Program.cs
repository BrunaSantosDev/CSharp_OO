using System;
using System.Globalization;

namespace Conversor {
    class Program {
        static void Main(string[] args) {
            // O objetivo do programa é fazer a conversão de dólar para real.

            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Qual é a cotação do dólar? ");
            double cotacao = double.Parse(Console.ReadLine(), CI);

            Console.Write("Quantos dólares você vai comprar? ");
            double quatia = double.Parse(Console.ReadLine(), CI);
            
            // Trazendo a classe ConversorDeMoeda para o Program.
            double resultado = ConversorDeMoeda.DolarParaReal(quatia, cotacao);

            Console.WriteLine("Valor a ser pago em reais = " + resultado.ToString("F2", CI));
        }
    }
}
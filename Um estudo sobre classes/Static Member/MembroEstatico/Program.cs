using System;
using System.Globalization;

namespace MembroEstatico {
    class Program {
        static void Main(string[] args) {
            // O objetivo do código é realizar o calculo da circunferencia e volume de um circulo a partir do raio.

            Console.WriteLine("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine());
            
            double circ = Calculadora.Circunferencia(raio);
            double volume = Calculadora.Volume(raio);

            Console.WriteLine("Circunferencia:  " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de PI: " + Calculadora.Pi.ToString("F2" , CultureInfo.InvariantCulture));
        }
    }
}
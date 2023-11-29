using System;

namespace Course {
    class Program {
        static void Main(string[] args) {

            //operador de coalescencia nula(??), se não tiver nada, ou seja, se for null ele adiciona o valor do lado:
            double? x = null;
            double? y = 10;

            double a = x ?? 5;
            double b = y ?? 5;

            Console.WriteLine(a);
            Console.WriteLine(b);

        }
    }
}
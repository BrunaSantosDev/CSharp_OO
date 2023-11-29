using System;
using System.Drawing;

namespace Course {
    class Program {
        static void Main(string[] args) {
            // O objetivo é mostrar um "ponto" em um plano cartesiano imaginário.

            Point p;
            p.X= 10;
            p.Y= 10;
            Console.WriteLine(p);

            p = new Point();
            Console.WriteLine("Digite x:");
            p.X = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite y:");
            p.Y = double.Parse(Console.ReadLine());

            Console.WriteLine(p);
        }
    }
}
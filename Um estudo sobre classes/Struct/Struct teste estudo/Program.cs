using System;
using System.Drawing;

namespace Course {
    class Program {
        static void Main(string[] args) {

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
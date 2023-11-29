using System;
using System.Globalization;

namespace Atividade2 {
    class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;
            double media;

            Funcionarios um, dois;
            um = new Funcionarios();
            dois = new Funcionarios();

            Console.WriteLine("Dados do primeiro funcionário: ");
            Console.Write("Nome: ");
            um.nome = Console.ReadLine();
            Console.Write("Salário: ");
            um.salario = int.Parse(Console.ReadLine(), CI);

            Console.WriteLine("Dados do primeiro funcionário: ");
            Console.Write("Nome: ");
            dois.nome = Console.ReadLine();
            Console.Write("Salário: ");
            dois.salario = double.Parse(Console.ReadLine(), CI);

            media = (um.salario + dois.salario) / 2;
            Console.WriteLine("Salário médio = " + media.ToString("F2", CI));
        }
    }

}
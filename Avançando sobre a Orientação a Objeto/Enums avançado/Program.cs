using System;
using Course.Entities;
using Course.Entities.Enums;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter department's name: ");
            string deptName = Console.ReadLine();
            Console.WriteLine("Enter worker data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base salary: ");
            CultureInfo CI = CultureInfo.InvariantCulture;
            double baseSalary = double.Parse(Console.ReadLine(), CI);

            Department dept = new Department(deptName);
            Worker worker = new Worker(name, level, baseSalary, dept); //instanciando o costrutor de worker com os dados, inclusive com a classe department

            Console.Write("How many contracts to this worker?");
            int contracts = int.Parse(Console.ReadLine());

            Console.WriteLine();
            for (int i = 1; i <= contracts; i++)
            {
                Console.WriteLine("Enter #" + i + " contract data:"); //ou pode usar cw¨($"Enter #{i} contract data:")
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CI);
                Console.Write("Duration (hours): ");
                int hours = int.Parse(Console.ReadLine());
                HourContract contract = new HourContract(date, valuePerHour, hours); //instanciado o construtor de HourContract
                worker.addContract(contract);//aqui utilizando o método addContract na list dentro da class Worker
                Console.WriteLine();
            }

            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            string monthAndYear = Console.ReadLine(); //aqui o dado digitado, no caso, mes e ano será lido
            int month = int.Parse(monthAndYear.Substring(0, 2)); //aqui o month será lido com int a partir da strinng monthAndYear, desta forma o substring deverá começar na posição [0] da string e terminar no charactere na posição 2, então, se o usuário digitar "23/2018" o month será lido como "23/"
            int year = int.Parse(monthAndYear.Substring(3)); //funciona da mesma forma que o month, porém o substring lê a partir da posição 3 que partindo do exemplo acima seria o "2018"
            Console.WriteLine("Name: " + worker.Name); //aqui acessamos a classe Worker já instanciada com a variável worker "printando" na tela o que está armazenado no Name dentro da class
            Console.WriteLine("Department: " + worker.Department.Name); //aqui é acessado a class Derpartment atraves da class worker, assim printando o dado name do department
            Console.WriteLine("Income for " + monthAndYear + ": " + worker.income(year, month)); //aqui finalmente printamos o que foi armazenado acima na variável monthAndYear e adicionamos o método income que está armazenado na classe worker
        }
    }
} 
using System;
using Course.Entities.Enums;
using System.Collections.Generic;

namespace Course.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; }
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();//tem que instanciar com new list para que a lista possa ter coisas adicionadas. A lógica por trás da implementação da lista é que "um trabalhador possui vários contratos", portanto uma lista para cada contrato deverá ser implementada

        public Worker()
        {
        }

        public Worker(string name, WorkerLevel level, double baseSalary, Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }//Não pode ter o construtor de contracts pois ele é muitos p/ muitos, tem q dividir ele assim como no banco de dados.

        public void addContract(HourContract contract)
        {
            Contracts.Add(contract);//adicionando um contrato para um trabalhador
        }

        public void removeContract(HourContract contract) 
        { 
            Contracts.Remove(contract); //removendo o contrato. Isso é a associação de objetos
        }

        public double income(int year, int month)
        {
            double sum = BaseSalary;
            foreach (HourContract contract in Contracts)
            {
                if(contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += contract.totalValue();
                }
            }
            return sum;
        }
    }
}

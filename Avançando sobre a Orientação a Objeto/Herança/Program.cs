using Course.Entities;
using System;
namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            //Account acc = new Account(1001, "Alex", 0.0);
            //BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500);

            //Upcasting
            //Account acc1 = bacc; //Converte businessAccount p var Account (já que as subclasses são parte da superclasse.
            //Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.0); //tb é possível já instanciar uma subclasse já atribuindo a uma variavel do tipo superclasse
            //Account acc3 = new SavingsAccount(1004, "Anna", 0.0, 0.01); //tb é possível atribuir uma outra subclasse p a mesma superclasse porém com uma instanciação de variavel diferente

            //Downcasting
            //é inseguro e deve ser usado só se for necessário e deve testar se a variavel pertence a classe correta  
            /* BusinessAccount acc4 = acc2; */ //não é possível fazer dessa forma, pois a var instanciada(cc2) pertence a superclasse Account para que funcione deverá ser feito assim:
            //BusinessAccount acc4 = (BusinessAccount)acc2; //só funciona ser for feito assim com casting(conversão de var já instanciada)
            //acc4.Loan(100.0);
            /* acc2.Loan*/ //Desse jeito não é possível usar o método Loan no acc2 pois ele pertence a subclasse BusinessAccount e a acc2 está instanciada para a superclasse Account que não possui este método

            //BusinessAccount acc5 = (BusinessAccount)acc3; n funciona pois a subclasse BusinessAccount não é a correta to acc3 e sim a SavingsAccount. Por isso deve ser testado da seguinte forma antes de ser implementado:
            //if (acc3 is BusinessAccount)
           // {
                //BusinessAccount acc5 = (BusinessAccount)acc3; //tem como fazer assim tb: BusinessAccount acc5 = acc3 as BusinessAccount;
                //acc5.Loan(200.0);
                //Console.WriteLine("Loan!");
           // }

            //if (acc3 is SavingsAccount)
            //{
               // SavingsAccount acc5 = (SavingsAccount)acc3;
               // acc5.UpdateBalace();
               // Console.WriteLine("Update!");
            //}
            
            Account acc1 = new Account(1001, "Alex", 500); 
            Account acc2 = new SavingsAccount(1002, "Ana", 500, 0.01);

            acc1.Withdraw(10);
            acc2.Withdraw(10);
            Console.WriteLine("Account: " + acc1.Balance);
            Console.WriteLine("SavingsAccount: " + acc2.Balance);

            //o saque ta funcionando igual desse jeito:
            //acc1.Withdraw(10);
            //acc2.Withdraw(10);
            //Console.WriteLine("Account: " + acc1.Balance); //sem virtual
            //Console.WriteLine("SavingsAccount: " + acc2.Balance); //sem override

        }
    }
}
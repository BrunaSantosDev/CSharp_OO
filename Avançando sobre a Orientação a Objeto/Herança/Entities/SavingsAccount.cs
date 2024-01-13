using System;

namespace Course.Entities
{
    class SavingsAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingsAccount() 
        { 
        }

        public SavingsAccount(int number, string holder, double balance, double interestRate) : base (number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalace()
        {
            Balance += Balance * InterestRate;
        }

        public override void Withdraw(double amount) //após escrever o public override o vs automaticamente oferece p implementar um dos métodos da superclasse, como o withdraw, já completando o método automaticamente, porém sem a taxa de 5
        {
            base.Withdraw(amount); //com a palavra base é possível reaproveitar exatamente o método da superclasse e ainda modificá-lo depois. Sem a palavra base a classe é override(sobrescrita) apenas
            Balance -= 2;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Entities
{
    internal class Account
    {
        public int Number { get; protected set; }
        public string Holder { get; protected set; }
        public double Balance { get; protected set; }
        //se eu colocar como private set todos as variáveis encapsuladas acima, eu consigo acessar na subclasse(por ex double dinheiro = balance;) porém não consigo mudar o que essa var possui ou foi atribuida(no caso eu n conseguiria colocar balance = 10;), também n consigo acessar métodos como o Loan() no BusinessAccount, por isso o Protected é melhor que o Private, pois ele pode ser alterado pela prória classe ou subclasse)
        public Account()
        {
        }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        public virtual void Withdraw(double amount)
        {
            Balance -= amount + 5.0;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Entities
{
    class BusinessAccount : Account //assim é declarado a herança
    {
        public double LoanLimit { get; set; }

        public BusinessAccount()
        {
        }

        public BusinessAccount(int number, string holder, double balance, double loanLimit) : base(number, holder, balance) //copiar construtor manualmente
        {
            //ao invés de repetir todas as atribuições, é só acionar o construtor de account assim: ": base(number, holder, balance) " e dps acrescentar o que falta(que foi add agr)
            LoanLimit = loanLimit;
        }

        public void Loan(double amount)
        {
            if (amount <= LoanLimit)
            {
                Balance += amount;
            }
        }
    }
}

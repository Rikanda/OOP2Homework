using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2Homework
{
    public class BankAccount
    {

        private int numberAccount;
        private double balanceAccount;
        private Type typeAccount;

        public int NumberAccount
        {
            get
            {
                return this.numberAccount;
            }

            set
            {
                this.numberAccount = value;
            }

        }

        public double BalanceAccount
        {
            get
            {
                return this.balanceAccount;
            }

            set
            {
                this.balanceAccount = value;
            }

        }

       
        public Type TypeAccount
        {
            get
            {
                return this.typeAccount;
            }

            set
            {
                this.typeAccount = value;
            }

        }

        // добавление на счет
        public void AddToAccount(double summ)
        {
            this.BalanceAccount = balanceAccount + summ;
            Console.WriteLine("Ваш счет увеличен на " + summ + ", " +
                "общая сумма по счету теперь составляет " + this.balanceAccount);
        }

        // снятие со счета
        public void Withdraw(double summ)
        {
            if(summ>this.balanceAccount)
            {
                Console.WriteLine("Снятие невозможно, поскольку запрошенная сумма больше остатка по счету");
            }
            else
            {
                this.BalanceAccount = balanceAccount - summ;
                Console.WriteLine("Ваш счет уменьшен на " + summ + ", " +
                "общая сумма по счету теперь составляет " + this.balanceAccount);
            }
        }

        public void PrintAccountData ()
        {
            Console.WriteLine("Номер счета: " + numberAccount + "; Баланс счета: " 
                + balanceAccount + "; Тип счета: " + typeAccount);
        }

    }
}

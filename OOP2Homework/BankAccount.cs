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
        public void PrintAccountData ()
        {
            Console.WriteLine("Номер счета: " + numberAccount + "; Баланс счета: " 
                + balanceAccount + "; Тип счета: " + typeAccount);
        }

    }
}

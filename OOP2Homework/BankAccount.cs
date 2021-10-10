using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2Homework
{
    class BankAccount
    {

        static int numberAccount = 1000;
        double balanceAccount;
        Type typeAccount;

        
        public void InsertNumberAccount()
        {
            ++numberAccount;
            
        }

        public void InsertBalanceAccount(double value)
        {
            balanceAccount = value;
        }

        public void InsertTypeAccount (Type value)
        {
            typeAccount = value;
        }

        public void PrintAccountData ()
        {
            Console.WriteLine("Номер счета: " + numberAccount + "; Баланс счета: " 
                + balanceAccount + "; Тип счета: " + typeAccount);
        }

    }
}

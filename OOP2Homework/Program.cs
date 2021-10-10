using System;

namespace OOP2Homework
{
    public enum Type
    {
        Дебетовый,
        Кредитовый,
        Накопительный
    }
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount testAccount = new BankAccount();
            int number = 1234;
            double balance = 100250.33;
            Type type = Type.Дебетовый;
            testAccount.InsertNumberAccount(number);
            testAccount.InsertBalanceAccount(balance);
            testAccount.InsertTypeAccount(type);
            testAccount.PrintAccountData();
            
        }
    }
}

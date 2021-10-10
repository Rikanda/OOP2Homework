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
            BankAccount testAccount1 = new BankAccount();
            testAccount1.PrintAccountData();

            BankAccount testAccount2 = new BankAccount(122345.98);
            testAccount2.PrintAccountData();

            BankAccount testAccount3 = new BankAccount(Type.Накопительный);
            testAccount3.PrintAccountData();

            BankAccount testAccount4 = new BankAccount(456789.01, Type.Дебетовый);
            testAccount4.PrintAccountData();

        }
    }
}

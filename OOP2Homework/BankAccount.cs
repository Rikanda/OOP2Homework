using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2Homework
{
    class BankAccount
    {

        private static int numberAccount = 1000;
        private double balanceAccount;
        private Type typeAccount;


        public int InsertNumberAccount()
        {
            int n = ++numberAccount;
            return n;

        }

        // конструктор по умолчанию обращается к конструктору для заполнения поля баланс
        public BankAccount() : this(100000.56)
        {

        }

        // конструктор для заполнения поля баланс
        public BankAccount (double b) : this (b, Type.Кредитовый)
        {
        
        }

        // конструктор для заполнения поля тип банковского счета
        public BankAccount(Type t) : this (100000.56, t)
        {

        }

        // конструктор для заполнения баланса и типа банковского счета
        public BankAccount(double b, Type t)
        {
            numberAccount = this.InsertNumberAccount();
            balanceAccount = b;
            typeAccount = t;
        }


        public void PrintAccountData ()
        {
            Console.WriteLine("Номер счета: " + numberAccount + "; Баланс счета: " 
                + balanceAccount + "; Тип счета: " + typeAccount);
        }

    }
}

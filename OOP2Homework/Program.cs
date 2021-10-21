using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public static void Test(TestCase testCase)
        {
            try
            {
                var actual = GenerationAccount(testCase.N, testCase.B, testCase.T);
                if (actual == testCase.Expected)
                {
                    Console.WriteLine("VALID TEST");
                }
                else
                {
                    Console.WriteLine("INVALID TEST");
                }
            }
            catch (Exception)
            {
                if (testCase.ExpectedException != null)
                {
                    Console.WriteLine("VALID TEST");
                }
                else
                {
                    Console.WriteLine("INVALID TEST");
                }
            }

        }

        public static string GenerationAccount (int n, double b, Type t)
        {
            BankAccount testAccount = new BankAccount()
            {
                NumberAccount = n,
                BalanceAccount = b,
                TypeAccount = t
                
            };

            string test = testAccount.NumberAccount.ToString() +
                testAccount.BalanceAccount.ToString() + testAccount.TypeAccount.ToString();

            testAccount.PrintAccountData();
            return test;

        }
        static void Main(string[] args)
        {
            int value1 = 2001;
            double value2 = 1000000.55;
            Type value3 = Type.Накопительный;
            string all = value1.ToString() + value2.ToString() + value3.ToString();

            var testCase = new TestCase()
            {
                N = value1,
                B = value2,
                T = value3,
                Expected = all,
                ExpectedException = null
            };

            Test(testCase);

            BankAccount newAccount = new BankAccount()
            {
                NumberAccount = value1,
                BalanceAccount = value2,
                TypeAccount = value3

            };


            Console.WriteLine($"Баланс счета {newAccount.BalanceAccount}.  Укажите сумму добавления на счет:");
            double s = double.Parse(Console.ReadLine());
            newAccount.AddToAccount(s);

            Console.WriteLine($"Баланс счета {newAccount.BalanceAccount}.  Укажите сумму снятия со счета:");
            double s1 = double.Parse(Console.ReadLine());
            newAccount.Withdraw(s1);


        }
    }
}

using System;
using System.Globalization;

namespace Account
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Enter the account number: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Enter the account holder's name: ");
            string name = Console.ReadLine();
            Console.Write("Will there be an initial deposit? (y/n)? ");
            char choice = char.Parse(Console.ReadLine());
            AccountData AC = new AccountData(id, name);

            if (choice == 'y')
            {
                Console.Write("Enter the initial deposit amount: ");
                double balance = double.Parse(Console.ReadLine(), CI);
                AC = new AccountData(id, name, balance);
            }

            Console.WriteLine();
            Console.WriteLine("Account data:");
            Console.WriteLine(AC);

            Console.WriteLine();
            Console.Write("Enter the deposit amount: ");
            double value = double.Parse(Console.ReadLine(), CI);
            AC.Deposit(value);
            Console.WriteLine("Updated account details:");
            Console.WriteLine(AC);

            Console.WriteLine();
            Console.Write("Enter an amount to withdraw: ");
            value = double.Parse(Console.ReadLine(), CI);
            AC.Withdraw(value);
            Console.WriteLine("Updated account details:");
            Console.WriteLine(AC);
        }
    }
}
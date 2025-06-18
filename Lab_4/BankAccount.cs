using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    class BankAccount
    {
        public string AccountHolderName;
        private double balance;
        public BankAccount(string accountHolderName, double initialBalance)
        {
            AccountHolderName = accountHolderName;
            balance = initialBalance;
            Console.WriteLine($"Account created for {AccountHolderName} with initial balance: {balance}");
            Console.WriteLine();

        }
        public void Deposit(double amount)
        {
            balance += amount;
            Console.WriteLine($"Deposited: {amount}\nNew Balance: {balance}");
            Console.WriteLine();
        }

        public void Deposit(string checkNumber, double amount)
        {
            balance += amount;
            Console.WriteLine($"Deposited via check {checkNumber}: {amount}\nNew Balance: {balance}");
            Console.WriteLine();
        }

        public void Withdraw(double amount)
        {
            if (amount <= balance)
            {
                balance -= amount;
                Console.WriteLine($"Withdrawn: {amount}\nNew Balance: {balance}");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Insufficient funds for withdrawal.");
            }
        }

        public void Withdraw(string checkNumber, double amount)
        {
            if (amount <= balance)
            {
                balance -= amount;
                Console.WriteLine($"Withdrawn via check {checkNumber}: {amount}\nNew Balance: {balance}");
            }
            else
            {
                Console.WriteLine("Insufficient funds for withdrawal.");
            }
        }
    }
}

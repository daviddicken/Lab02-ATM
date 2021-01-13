using System;

namespace Lab02_ATM
{
    public class Program
    {
        public static decimal Balance;
        public static void Main(string[] args)
        {

            Welcome();

        }

        //=================
        public static void Welcome()
            {
            decimal amount;
            bool flag = true;
            do
            {
                Console.WriteLine($"Hello, how may I help you today:" +
                    $"\nPress 1 for Deposit\nPress 2 for Withdraw\nPress 3 to View Balance\nPress 4 to exit.");
                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        Console.WriteLine("Amount to Deposit:");
                        amount = Convert.ToDecimal(Console.ReadLine());
                        Deposit(amount);
                       break;
                    case "2":
                        Console.WriteLine("Amount to withdraw:");
                        amount = Convert.ToDecimal(Console.ReadLine());
                        Withdraw(amount);
                        break;
                    case "3":
                        //Console.WriteLine($"Your balance is: {Balance}");
                        break;
                    case "4":
                        flag = false;
                        break;
                    default:
                        break;
                }
                Console.WriteLine($"Your balance is: {Balance}\n\n");
            } while (flag);
            }

        //==================
        public static decimal ViewBalance()
        {
            return Balance;
        }

        //=================
        public static decimal Withdraw(decimal amount)
        {
            if(amount < 1 || amount > Balance)
            {
                Console.WriteLine("Unable to withdraw that amount.");
                Console.WriteLine($"Your balance is {Program.Balance}.");
                return Balance;
            }

            Balance -= amount;

            return Balance;
        }

        //================
        public static decimal Deposit(decimal amount)
        {
            if(amount < 1)
            {
                Console.WriteLine("You need to deposit more then that.");
                return Balance;
            }
            Balance += amount;

            return Balance;
        }
    }
}

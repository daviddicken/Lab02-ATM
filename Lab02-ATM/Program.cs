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
                Console.WriteLine($"Hello, how may I help you today:\n" +
                    $"Press 1 for Deposit\n" +
                    $"Press 2 for Withdraw\n" +
                    $"Press 3 to Exit\n" +
                    $"Any other key to View Balance");
                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        Console.WriteLine("Amount to Deposit:");
                        try
                        {
                            amount = Convert.ToDecimal(Console.ReadLine());
                            Deposit(amount);
                        }catch(FormatException fe)
                        {
                            Console.WriteLine("Invalid entry. Please only use numbers.");
                        }   
                        break;
                    case "2":
                        Console.WriteLine("Amount to withdraw:");
                        try
                        {
                            amount = Convert.ToDecimal(Console.ReadLine());
                            Withdraw(amount);
                        }catch(FormatException fe)
                        {
                            Console.WriteLine("Invalid entry. Please only use numbers.");
                        }
                        break;
                    case "3":
                        flag = false;
                        break;
                    default:
                        break;
                }
                Console.WriteLine($"Your balance is: {Balance}\n\n");
                bool badAnswer = true;
                do
                {
                    Console.WriteLine("Would you like another transaction? Y/N");
                    string exit = Console.ReadLine().ToLower();
                    if(exit == "n")
                    {
                        Console.WriteLine("Have a nice day.");
                        badAnswer = false;
                        flag = false;
                    }else if(exit == "y")
                    {
                        badAnswer = false;
                    }
                    else
                    {
                        badAnswer = true;
                    }
                } while (badAnswer);
                
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
            if(amount > Balance)
            {
                Console.WriteLine($"Unable to withdraw that amount. You only have {Balance} in your account.");
                return Balance;
            }
            if(amount < 1)
            {
                Console.WriteLine("The amount to withdraw needs to be greater then 0");
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

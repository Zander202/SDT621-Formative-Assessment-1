using System;
using System.Globalization;

namespace ATMSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== CTU SIMPLE ATM SYSTEM =====");
            Console.WriteLine();

            // Get user name
            Console.WriteLine("HI , WHAT IS YOUR NAME?");
            string name = Console.ReadLine().ToUpper();
            Console.WriteLine();

            // Welcome message
            Console.WriteLine($"WELCOME {name}!");

            // Get and validate account balance
            decimal balance = 0;
            while (true)
            {
                Console.Write("Enter account balance: ");
                string input = Console.ReadLine().Replace(",", ".");
                if (decimal.TryParse(input, NumberStyles.Any,
                    CultureInfo.InvariantCulture, out balance))
                    break;
                else
                    Console.WriteLine("Invalid input. Please enter a numeric value.");
            }

            // Get and validate withdrawal amount
            decimal withdrawalAmount = 0;
            while (true)
            {
                Console.Write("Enter withdrawal amount: ");
                string input = Console.ReadLine().Replace(",", ".");
                if (decimal.TryParse(input, NumberStyles.Any,
                    CultureInfo.InvariantCulture, out withdrawalAmount))
                {
                    if (withdrawalAmount > balance)
                        Console.WriteLine("Insufficient funds. Please enter a smaller amount.");
                    else if (withdrawalAmount <= 0)
                        Console.WriteLine("Amount must be greater than zero.");
                    else
                        break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a numeric value.");
                }
            }

            // Calculate updated balance
            decimal updatedBalance = balance - withdrawalAmount;
            string timestamp = DateTime.Now.ToString("dd MMM yyyy HH:mm:ss");

            // Display results
            Console.WriteLine();
            Console.WriteLine("Withdrawal successful!");
            Console.WriteLine($"Updated Balance: {updatedBalance:F2}");
            Console.WriteLine($"Transaction Time: {timestamp}");

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
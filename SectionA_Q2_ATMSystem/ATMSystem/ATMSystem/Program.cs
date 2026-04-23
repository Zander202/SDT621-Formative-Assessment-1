using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== CTU Simple Atm System =====");
            Console.WriteLine();


            //Get user name
            Console.Write("Hi ,What is your name? ");
            string name = Console.ReadLine().ToUpper();
            Console.WriteLine();

            //Welcome message
            Console.WriteLine($"Welcome {name}!");

            //Get and validate account balance
            double balance = 0;
            while (true)
            {
                Console.Write("Enter account balance: ");
                if (double.TryParse(Console.ReadLine(), out balance))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a numeric value");
                }
                {

                }
            }
            //Get and validate withdrawal amount
            double withdrawalAmount = 0;
            while (true)
            {
                Console.Write("Enter withdrawal amount: ");
                if (double.TryParse(Console.ReadLine(), out withdrawalAmount))
                {
                    if (withdrawalAmount > balance)
                    {
                        Console.WriteLine("Insufficient funds. Please enter a smaller amount.");
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a numeric value");
                }

            }
            //Calculate and Update balance
            double updatedBalance = balance - withdrawalAmount;
            string timestamp = DateTime.Now.ToString("dd MMM yyyy HH:mm:ss");

            //Display Results
            Console.WriteLine();
            Console.WriteLine($"Withdrawal successful!");
            Console.WriteLine($"Updated Balance: {updatedBalance:F2}");
            Console.WriteLine($"Transaction Time: {timestamp}");

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();


        }




    }
}

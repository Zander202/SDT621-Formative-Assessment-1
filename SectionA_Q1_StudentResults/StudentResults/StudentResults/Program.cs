using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentResults
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Get Name of Student
            Console.Write("Enter the name of the student:");
            string studentname = Console.ReadLine();

            //Get and Validate the marks of the student
            double mark1 = 0;
            while(true)
            {
                Console.Write ("Enter mark for subject 1:");
                if (double.TryParse(Console.ReadLine(), out mark1))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a numeric value");
                }

            }
                //Get and Validate mark 2
                double mark2 = 0;
                while (true)
                {
                    Console.Write("Enter mark for subject 2:");
                    if (double.TryParse(Console.ReadLine(), out mark2))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a numeric value");
                    }
                }

            //Get and Validate mark 3
            double mark3 = 0;
            while (true)
            {
                Console.Write("Enter mark for subject 3:");
                if (double.TryParse(Console.ReadLine(), out mark3))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a numeric value");
                }
            }
            //Calculate
            double total = mark1 + mark2 + mark3;
            double average = total / 3;
            string result = average >= 50 ? "Pass" : "Fail";
            string timestamp = DateTime.Now.ToString("dd MMM yyyy HH:mm:ss");

            // Display results
            Console.WriteLine("\n===== STUDENT RESULTS =====");
            Console.WriteLine($"Student Name: {studentname}");
            Console.WriteLine($"Total Marks: {total}");
            Console.WriteLine($"Average Marks: {average:F1}");
            Console.WriteLine($"Result: {result}");
            Console.WriteLine($"Result Issued At: {timestamp}");

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}

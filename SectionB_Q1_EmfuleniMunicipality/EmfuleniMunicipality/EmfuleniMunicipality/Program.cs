using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EmfuleniMunicipality;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Welcome to Emfuleni Municipality Service Desk ===\n");

        UtilitiesManager manager = new UtilitiesManager();
        List<Resident> residents = new List<Resident>();

        // ── STEP 1: Capture resident details
        int residentCount = ReadPositiveInt("How many residents do you want to register? ");

        for (int i = 0; i < residentCount; i++)
        {
            Console.WriteLine($"\n--- Resident {i + 1} ---");

            Console.Write("Name: ");
            string name = Console.ReadLine()?.Trim() ?? "Unknown";

            Console.Write("Address: ");
            string address = Console.ReadLine()?.Trim() ?? "Unknown";

            Console.Write("Account Number: ");
            string account = Console.ReadLine()?.Trim() ?? "Unknown";

            double usage = ReadPositiveDouble("Monthly Utility Usage (kWh or litres): ");

            residents.Add(new Resident(name, address, account, usage));
        }

        //STEP 2: Capture service requests 
        Console.WriteLine();
        int requestCount = ReadPositiveInt("How many service requests do you want to log? ");

        for (int i = 0; i < requestCount; i++)
        {
            Console.WriteLine($"\n--- Service Request {i + 1} ---");

            // Show residents for selection
            for (int r = 0; r < residents.Count; r++)
                Console.WriteLine($"  {r + 1}. {residents[r].Name}");

            int residentChoice = ReadIntInRange("Select resident by number: ", 1, residents.Count);
            Resident selected = residents[residentChoice - 1];

            Console.Write("Request Type (e.g., Water Outage, Burst Pipe): ");
            string requestType = Console.ReadLine()?.Trim() ?? "General";

            int priority = ReadIntInRange("Priority Level (1-5): ", 1, 5);
            int severity = ReadIntInRange("Severity Level (1-10): ", 1, 10);
            double estHours = ReadPositiveDouble("Estimated Resolution Hours: ");

            ServiceRequest request = new ServiceRequest(selected, requestType, priority, severity, estHours);
            manager.EnqueueRequest(request);

            Console.WriteLine($"  [+] Request logged. Urgency Score: {request.UrgencyScore:F0}");
        }

        //STEP 3 & 4: Display queue and process interactively
        while (manager.PendingCount > 0)
        {
            manager.DisplayPendingQueue();

            Console.WriteLine($"\n{manager.PendingCount} request(s) remaining.");
            Console.Write("Enter queue number to process (or 0 to stop): ");

            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                if (choice == 0) break;
                manager.ProcessRequest(choice);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
        }

        //STEP 5 & 6: Final summary
        manager.GenerateFinalSummary();
    }

    //Input helpers

    static int ReadPositiveInt(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            if (int.TryParse(Console.ReadLine(), out int value) && value > 0)
                return value;
            Console.WriteLine("Please enter a positive whole number.");
        }
    }

    static double ReadPositiveDouble(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            if (double.TryParse(Console.ReadLine(), out double value) && value > 0)
                return value;
            Console.WriteLine("Please enter a positive number.");
        }
    }

    static int ReadIntInRange(string prompt, int min, int max)
    {
        while (true)
        {
            Console.Write(prompt);
            if (int.TryParse(Console.ReadLine(), out int value) && value >= min && value <= max)
                return value;
            Console.WriteLine($"Please enter a number between {min} and {max}.");
        }
    }
}
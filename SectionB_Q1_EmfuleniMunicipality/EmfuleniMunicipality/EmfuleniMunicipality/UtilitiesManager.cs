using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmfuleniMunicipality
{
    public class UtilitiesManager
    {
        private List<ServiceRequest> _pendingQueue;
        private List<ServiceRequest> _processedRequests;

        public int PendingCount => _pendingQueue.Count;
        public int ProcessedCount => _processedRequests.Count;

        public UtilitiesManager()
        {
            _pendingQueue = new List<ServiceRequest>();
            _processedRequests = new List<ServiceRequest>();
        }

        // ── Add a request and keep the queue sorted by urgency (highest first) ──
        public void EnqueueRequest(ServiceRequest request)
        {
            _pendingQueue.Add(request);
            _pendingQueue = _pendingQueue.OrderByDescending(r => r.UrgencyScore).ToList();
        }

        // ── Display all pending requests ──────────────────────────────────────
        public void DisplayPendingQueue()
        {
            Console.WriteLine("\n=== Pending Service Requests ===");

            if (_pendingQueue.Count == 0)
            {
                Console.WriteLine("No pending requests.");
                return;
            }

            Console.WriteLine($"  {"#",-4} {"Resident",-20} {"Request Type",-22} {"Priority",-10} {"Severity",-10} {"Est. Hours",-12} {"Urgency Score"}");
            Console.WriteLine(new string('-', 92));

            for (int i = 0; i < _pendingQueue.Count; i++)
            {
                var r = _pendingQueue[i];
                Console.WriteLine($"  {i + 1,-4} {r.AssociatedResident.Name,-20} {r.RequestType,-22} " +
                                  $"{r.PriorityLevel,-10} {r.SeverityLevel,-10} " +
                                  $"{r.EstimatedResolutionHours,-12:F1} {r.UrgencyScore:F0}");
            }
            Console.WriteLine(new string('-', 92));
        }

        // ── Process a request by its queue position (1-based) ────────────────
        public bool ProcessRequest(int queuePosition)
        {
            if (queuePosition < 1 || queuePosition > _pendingQueue.Count)
            {
                Console.WriteLine($"Invalid selection. Choose between 1 and {_pendingQueue.Count}.");
                return false;
            }

            ServiceRequest request = _pendingQueue[queuePosition - 1];
            _pendingQueue.RemoveAt(queuePosition - 1);
            request.IsProcessed = true;
            _processedRequests.Add(request);

            PrintServiceReport(request);
            return true;
        }

        // ── Per-request report ────────────────────────────────────────────────
        private void PrintServiceReport(ServiceRequest req)
        {
            Console.WriteLine("\n=== Service Report ===");
            Console.WriteLine($"Resident: {req.AssociatedResident.Name}");
            Console.WriteLine($"Address: {req.AssociatedResident.Address}");
            Console.WriteLine($"Account Number: {req.AssociatedResident.AccountNumber}");
            Console.WriteLine($"Monthly Utility Usage: {req.AssociatedResident.MonthlyUtilityUsage}");
            Console.WriteLine($"Service Type: {req.RequestType}");
            Console.WriteLine($"Priority Level: {req.PriorityLevel}");
            Console.WriteLine($"Severity Level: {req.SeverityLevel}");
            Console.WriteLine($"Estimated Resolution Hours: {req.EstimatedResolutionHours:F1}");
            Console.WriteLine($"Adjusted Resolution: {req.AdjustedResolution:F0} hours");
            Console.WriteLine($"Urgency Score: {req.UrgencyScore:F0}");
            Console.WriteLine($"Household Impact Score: {req.HouseholdImpactScore:F2}".Replace(".", ","));
            Console.WriteLine("======================");
        }

        // ── Final summary after all processing ────────────────────────────────
        public void GenerateFinalSummary()
        {
            Console.WriteLine("\n==== FINAL MUNICIPAL SUMMARY ====");

            if (_processedRequests.Count == 0)
            {
                Console.WriteLine("No requests were processed.");
                Console.WriteLine("\nThank you for using the Emfuleni Municipality Service Desk.");
                return;
            }

            ServiceRequest highest = _processedRequests.OrderByDescending(r => r.UrgencyScore).First();

            Console.WriteLine("Highest priority issue:");
            Console.WriteLine($"Resident: {highest.AssociatedResident.Name}");
            Console.WriteLine($"Service Type: {highest.RequestType}");
            Console.WriteLine($"Urgency Score: {highest.UrgencyScore:F0}");
            Console.WriteLine($"Adjusted Resolution: {highest.AdjustedResolution:F0} hours");
            Console.WriteLine($"Household Impact Score: {highest.HouseholdImpactScore:F2}".Replace(".", ","));

            Console.WriteLine("\nThank you for using the Emfuleni Municipality Service Desk.");
        }
    }
}
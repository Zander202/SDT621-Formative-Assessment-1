using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmfuleniMunicipality
{
    public class ServiceRequest
    {
        private static int _idCounter = 1;

        public int RequestId { get; private set; }
        public Resident AssociatedResident { get; set; }
        public string RequestType { get; set; }
        public int PriorityLevel { get; set; }        // 1–5
        public int SeverityLevel { get; set; }        // 1–10
        public double EstimatedResolutionHours { get; set; }
        public bool IsProcessed { get; set; }

        public double AdjustedResolution { get; private set; }
        public double UrgencyScore { get; private set; }
        public double HouseholdImpactScore { get; private set; }

        private const double BaselineMonthlyUsage = 456.0;

        public ServiceRequest(Resident resident, string requestType, int priorityLevel,
                              int severityLevel, double estimatedHours)
        {
            RequestId = _idCounter++;
            AssociatedResident = resident;
            RequestType = requestType;
            PriorityLevel = priorityLevel;
            SeverityLevel = severityLevel;
            EstimatedResolutionHours = estimatedHours;
            IsProcessed = false;

            CalculateScores();
        }

        private void CalculateScores()
        {
            // Adjusted resolution scales estimated time by severity relative to priority
            AdjustedResolution = EstimatedResolutionHours * (1.0 + (double)SeverityLevel / PriorityLevel);

            // Urgency score: combines priority weight with adjusted resolution time
            UrgencyScore = PriorityLevel * 10.0 * AdjustedResolution;

            // Household impact: scales urgency against resident's actual utility consumption
            HouseholdImpactScore = UrgencyScore * (AssociatedResident.MonthlyUtilityUsage / BaselineMonthlyUsage);
        }

        public override string ToString()
        {
            return $"[ID:{RequestId}] {RequestType} | Resident: {AssociatedResident.Name} " +
                   $"| Priority: {PriorityLevel} | Severity: {SeverityLevel} " +
                   $"| Est. Hours: {EstimatedResolutionHours:F1} | Urgency: {UrgencyScore:F0}";
        }
    }
}
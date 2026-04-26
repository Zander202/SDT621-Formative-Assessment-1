using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAffairsProcessor
{
    public class CitizenProfile
    {
        public string FullName { get; set; }
        public string IDNumber { get; set; }
        public int Age { get; set; }
        public string CitizenshipStatus { get; set; }

        public CitizenProfile(string fullName, string idNumber, string citizenshipStatus)
        {
            FullName = fullName;
            IDNumber = idNumber;
            CitizenshipStatus = citizenshipStatus;
            Age = CalculateAge();
        }

        private int CalculateAge()
        {
            if (IDNumber.Length < 6) return 0;

            if (!int.TryParse(IDNumber.Substring(0, 2), out int yy)) return 0;
            if (!int.TryParse(IDNumber.Substring(2, 2), out int mm)) return 0;
            if (!int.TryParse(IDNumber.Substring(4, 2), out int dd)) return 0;

            int currentYY = DateTime.Now.Year % 100;
            int fullYear = yy > currentYY ? 1900 + yy : 2000 + yy;

            try
            {
                DateTime birthDate = new DateTime(fullYear, mm, dd);
                int age = DateTime.Now.Year - birthDate.Year;
                if (DateTime.Now < birthDate.AddYears(age)) age--;
                return age;
            }
            catch
            {
                return 0;
            }
        }

        public string ValidateID()
        {
            if (IDNumber.Length != 13)
                return "Invalid ID. Must be exactly 13 digits.";

            foreach (char c in IDNumber)
                if (!char.IsDigit(c))
                    return "Invalid ID. Must contain digits only.";

            if (Age <= 0 || Age > 130)
                return "Invalid ID. Birth date could not be determined.";

            return $"Valid ID. Citizen is {Age} years old.";
        }
    }
}
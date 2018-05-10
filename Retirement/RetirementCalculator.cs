using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retirement
{
    public class RetirementCalculator
    {
        public List<Country> Countries { get; set; }

        public RetirementCalculator()
        {
            Countries = new List<Country>();
        }

        public RetirementCalculator(string path)
        {
            GetRetirementsFromFile(path);
        }

        public DateTime GetTimeRetirementDate(Person person)
        {
            int retirementAgeYears;
            int retirementAgeMonths;

            if (person.Gender == Gender.Woman)
            {
                retirementAgeYears = person.Country.RetirementAge.Women.Years;

                if (person.Country.RetirementAge.Women.Months != null)
                    retirementAgeMonths = (int)person.Country.RetirementAge.Women.Months;
            }

            else
            {
                retirementAgeYears = person.Country.RetirementAge.MenOrDefault.Years;

                if (person.Country.RetirementAge.MenOrDefault.Months != null)
                    retirementAgeMonths = (int)person.Country.RetirementAge.MenOrDefault.Months;
            }

            return person.Birthdate.AddYears(retirementAgeYears).AddMonths(retirementAgeMonths);
        }

        public void GetRetirementsFromFile(string path)
        {
            Countries = new List<Country>();
            var file = File.ReadAllLines(path);

            foreach (var country in file)
            {
                throw new NotImplementedException();
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retirement
{
    public class Country
    {
        public string Name { get; set; }
        public Retirement RetirementAge { get; set; }
        public Dictionary<int, Retirement> PlannedRetirementAges { get; set; }

        public Country(string name, Retirement retirementAge)
        {
            Name = name;
            RetirementAge = retirementAge;
        }
    }
}

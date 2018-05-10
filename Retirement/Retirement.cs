using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retirement
{
    public class Retirement
    {
        public RetirementAge MenOrDefault { get; set; }
        public RetirementAge Women { get; set; }
        public bool IsEqualForAll => MenOrDefault == Women;
    }
}

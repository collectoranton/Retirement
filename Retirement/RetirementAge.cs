using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retirement
{
    public class RetirementAge : IEquatable<RetirementAge>
    {
        public int Years { get; set; }
        public int? Months { get; set; }
        public int? SpanToYears { get; set; }
        public int? SpanToMonths { get; set; }

        public RetirementAge(int years, int? months = null, int? spanToYears = null, int? spanToMonths = null)
        {
            Years = years;
            Months = months;
            SpanToYears = spanToYears;
            SpanToMonths = spanToMonths;
        }

        public bool Equals(RetirementAge other)
        {
            return other.Years == Years &&
                   other.Months == Months &&
                   other.SpanToYears == SpanToYears &&
                   other.SpanToMonths == SpanToMonths;
        }
    }
}

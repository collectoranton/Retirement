using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retirement
{
    public enum Gender
    {
        Man,
        Woman,
        Unknown
    }

    public class Person
    {
        public DateTime Birthdate { get; set; }
        public Country Country { get; set; }
        public Gender Gender { get; set; }

        public Person(DateTime birthdate, Country country, Gender gender = Gender.Unknown)
        {
            Birthdate = birthdate;
            Country = country ?? throw new ArgumentNullException(nameof(country));
            Gender = gender;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retirement
{
    public class UI
    {
        public static void Run()
        {
            var retirementCalculator = new RetirementCalculator();

            Console.Write("Enter birtdate: ");
            var birthdate = Console.ReadLine();

            Console.WriteLine("Enter country: ");
            var country = Console.ReadLine();
            
            Console.WriteLine("Enter gender (optional): ");
            var gender = Console.ReadLine();

            
        }
    }
}

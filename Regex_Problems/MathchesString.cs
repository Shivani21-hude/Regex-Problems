using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Regex_Problems
{
    internal class MathchesString
    {
       
        public void Matchesstring()
        {
            //step 1: create object of regex
              Regex regex = new Regex(@"^[a]{1}[b]{2,3}$");

            Console.WriteLine("Enter a string");
            string word=Console.ReadLine();

            // Step 2: call Match on Regex instance.
            Match match = regex.Match(word);

            // Step 3: test for Success.
            if (match.Success)
            {
                Console.WriteLine("It is VALID : ");
            }
            else
            {
                Console.WriteLine("string is not valid");
            }

        }

    }
}

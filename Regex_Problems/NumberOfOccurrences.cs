using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Regex_Problems
{
    internal class NumberOfOccurrences
    {
        public static void Occurrences()
        {
            string input= "foxes are omnivorous mammals belonging to several genera of the family Canidae fox.”";
            Regex pattern =new Regex(@"fox(es)?");
            
            MatchCollection match = pattern.Matches( input);

            Console.WriteLine("fox|es is occur {0} times", match.Count);
          
           
        }
    }
}
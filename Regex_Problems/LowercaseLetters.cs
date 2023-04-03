using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace Regex_Problems
{
    internal class LowercaseLetters
    {
        public static void LowercaseLettersJoinedByUnderscore()
        {
            Regex regex = new Regex("^[a-z]+_+[a-z]+$");
            Console.WriteLine("Enter string with lowercase joined by underscore : ");
            string word=Console.ReadLine();
            if (regex.IsMatch(word))
            {
                Console.WriteLine("Valid string");
            }
            else
            {
                Console.WriteLine("Invalid string");
            }
        }
    }
}

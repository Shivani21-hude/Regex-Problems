using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace Regex_Problems
{
    internal class ValidWebsiteAddress
    {
        public static void URLAddress()
        {
            Regex regex = new Regex(@"^(http|http(s)?://)?([\w-]+\.)+[\w-]+[.com|.in|.org]+(\[\?%&=]*)?");
            Console.WriteLine("Enter a url ");           
            string Website = Console.ReadLine();
            if (regex.IsMatch(Website))
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Not valid");
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Regex_Problems
{
    internal class Fetch_HTML_Tags
    {
        public static void HTMLTags()
        {
            string input = "<p>The <code>Regex</code> is a compiled representation of a regular expression.</p>";
            string pattern = @"<[^>]+>";

            MatchCollection match1 = Regex.Matches(input, pattern);

            foreach (Match matches in match1)
            {
                Console.WriteLine(matches.Value);
            }
        }
    }
}

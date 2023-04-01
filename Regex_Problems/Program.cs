using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regex_Problems
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" *** Problems using Regex *** \n");
            Console.WriteLine("take 1 option from given \n 1) Matches a string that has an ‘a’ followed by two\r\nto three 'b'" +
                "\n 2) To Find sequences of lowercase letters joined by an underscore" +
                "\n 3) Regex to find valid file names with an image file type with extension.\n" +
                " 4) Use Regular expression to validate a website address format.\n " +
                " 5) Fetch HTML Tags using regex \n ");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    MathchesString Valid = new MathchesString();
                    Valid.Matchesstring();
                    break;
                case 2:
                    LowercaseLetters.LowercaseLettersJoinedByUnderscore();
                    break;
                case 3:
                    ImageFileExTension.FileExtension();
                    break;
                case 4:
                    ValidWebsiteAddress.URLAddress();
                    break;

                case 5:
                    Fetch_HTML_Tags.HTMLTags();
                    break;
            }
        
        
        }
    }
}
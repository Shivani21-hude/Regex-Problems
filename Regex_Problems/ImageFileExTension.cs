using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net.NetworkInformation;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Regex_Problems
{
    internal class ImageFileExTension
    {

        public static void FileExtension()
        {
            Regex regex = new Regex(@"([^\s]+(\.(?i)(jpe?g|png|gif|bmp))$)");   //[^\s]  represent the string must atleast one char
           
            Console.WriteLine("Enter filename with image file extension : ");    //\.  repsent the string follow by .
            string filename = Console.ReadLine();                                // ?i ignore case sensative
            if (regex.IsMatch(filename))
            {
                Console.WriteLine("Valid file name");      //abc.jpe
            }
            else
            {
                Console.WriteLine("Invalid file name");
            }
        }
    }
}

// Program for reverse number

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpNew
{
    internal class Test2
    {

        static void Main()
        {

            Console.WriteLine("Enter the No for reverse: ");
            String inputNumber = Console.ReadLine();
            String revereversedNumber = ReverseNumber(inputNumber);
            Console.WriteLine("Result after reverse :" + revereversedNumber);

        }

        static String ReverseNumber(String Manu)
        {
            String reverse = "";

            foreach (char c in Manu)
            {
                reverse = c + reverse;

            }
            return reverse;

        }
    }
    
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


   Console.WriteLine("Enter the Input for String : ");
 String Input = Console.ReadLine();
String Reverse = ReverseString(Input);
Console.WriteLine("The Reverse String value is : " + Reverse);

String ReverseString(String Str)
{

    String Reverse = "";

    foreach (char item in Str)
    {
        Reverse = item + Reverse;

    }
    return Reverse;

}




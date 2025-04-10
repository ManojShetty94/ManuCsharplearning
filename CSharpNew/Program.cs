using System.Diagnostics;

namespace CSharpNew
{
    internal class Program
    {

        {        public void getdata()

            Console.WriteLine("Here declaring method in outside the main method");
        }

        static void Main(string[] args)
        {

            Program M = new Program(); // Here, I creeated the object for the class [Program] and calling the call into the main method

            M.getdata(); // M is an Object to the class "Program"

            Console.WriteLine("Hello, Manoj Shetty");  // Use "Console" class if you want to see the output in Console[Terminal].
         // Debug.WriteLine("Hello, Manoj Shetty");  // Use "Debug" class if you want to see the output in Debug screen.

            int num = 10;
            Console.WriteLine("Number is " +num);
            String name = "Manoj Shetty";
            Console.WriteLine("Name is" +name);
            double b = 10.32;
            Console.WriteLine("Decimal value is " +b);

            Console.WriteLine($"number is {num}, Name is {name}, Decimal no is {b}");

            //The $ before the string tells the compiler to process the string as an interpolated string, 
            //meaning that expressions within {} will be evaluated and their values will be inserted directly into the string.

            var hiegt = "Manu";
            Console.WriteLine(hiegt);

            dynamic data = 10;
            data = "Prgram written by Manoj Shetty";
            Console.WriteLine(data);


        }
    }
}

using System; 
using System.Collections.Generic; 
using System.Linq; 
using System.Text;
using System.Threading.Tasks;

namespace CSharpNew // Declares a namespace named 'CSharpNew'
{
    class ReverseString // Declares a class named 'ReverseString'
    {
        static void Main() // Entry point of the program
        {
            Console.WriteLine("Enter the String : "); // Ask user to input a string

            String input = Console.ReadLine(); // Reads the user input and stores it in 'input'

            String Reversed = ReversedUsingForeach(input); // Calls the method to reverse the string

            Console.WriteLine("Reversed String is:" + Reversed); // Prints the reversed string
        }

        // Method to reverse a string using foreach loop
        static String ReversedUsingForeach(String Str)
        {
            String Reversed = ""; // Initialize an empty string to build the reversed string

            foreach (char c in Str) // Loop through each character in the input string
            {
                Reversed = c + Reversed; // Prepend the character to the result to reverse the order
            }

            return Reversed; // Return the reversed string
        }
    }
}

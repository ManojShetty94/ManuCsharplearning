using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpNew;

namespace CSharpNew
{
    
   class Car
    {
        public String Model; // 3 attributes
        public int Year;
        public String Name;

        public  Car() // Default constructor
        {
            Model = "Unknown";
            Year = 0;
            Name = "Krish";

        }

               public Car(string model, int year, string name) //Parameterized Constructor (Car(string model, int year, string name))
        {
            Model = model;    //This is an overloaded constructor, which allows you to initialize a Car object with specific values.
            Year = year;
            Name = name;
        }

        public void DisplayInfo() //This is a method that displays the information about the car.

      {

            Debug.WriteLine($"Model : {Model}, Year: {Year}, Name : {Name}");

        }

    }


    class ConstructorTest // Main programm
    {
        static void Main()
        {
            Car Car1 = new Car(); // Using the default constructor
            Car1.DisplayInfo(); // Display info of Car1 (default values)

            Car Car2 = new Car("Toyota", 1993, "MB"); // Using the parameterized constructor
            Car2.DisplayInfo(); // Display info of Car2 (custom values)


        }


    }
}


////Constructors:

//The Car class has two constructors:

//A default constructor that initializes the Car object with predefined values.

//A parameterized constructor that allows custom values for the Car object.

//DisplayInfo():

//A method that outputs the details of the car to the debug output.

//Object Creation:

//Car1 is created using the default constructor, and Car2 is created using the parameterized constructor.


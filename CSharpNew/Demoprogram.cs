using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpNew;
using OpenQA.Selenium.DevTools.V131.DOM;

namespace CSharpNew
{
    class Demoprogram : Inheritanceclass // Here, ":" indicates inheretance, where we use extends in Java
    {
        public void Krish()
        {

            Debug.WriteLine("Hare Krishna Hare Krishna ");

        
        }
        public void Hanuman()
        {

            Debug.WriteLine("Jai Hanuman jnangun Sagar");
        }

        public void Shiva()
        {

            Debug.WriteLine("Om Triyambakam Yajamaye Sugandim pustivardhanam");
        }


        public static void Main(string[] args)
        {

            Demoprogram D = new Demoprogram();

            D.Krish();
            D.Hanuman();
            D.Shiva();
            D.Testdata();

        }
    }
}


// Here, I have created multple methods[Krish, Hanuman and Shiva] outside the main method under the class name "Demoprogram"
//Then, I have created the main method
// here, I have created one object[D] for class "Demoprogram" and invoking the all the three method values into D object "Demoprogram D = new Demoprogram();"
// "New" = allocates memory for an object[D] and invokes its constructor.
// then i have invoked all the 3 methods into object "D" and printing the vakues.
//D.Krish();
//D.Hanuman();
//D.Shiva();
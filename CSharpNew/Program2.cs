using System;
using System.Diagnostics;
using CSharpNew;


Debug.WriteLine("I have created the new class without main mentod");

// global Scope of main. If you are not declaring the main method for new class.
// then It treat that class as main method by run time
//And it runs this class instead of running the main method declared class.

// How to make run the 1st program

// Right click on the class -> Properties -> make build action as "none"

Demoprogram D = new Demoprogram();
D.Krish();
D.Hanuman();
D.Shiva();

// Here, I'm calling "Method" from another class "Demoprogram"
// created another object here "Demoprogram D = new Demoprogram();" and called all the methods from the another class
// While running the program, We have to make a changes in Compiling program in properties for both the class


using System;

namespace GitExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Test");
            Console.WriteLine("NULL POINTER");

            myClass myclass = new myClass("Orhan", "Strandvejen", 88889999);

            System.Console.WriteLine(myclass.GetInfo(myclass));



        }
    }
}

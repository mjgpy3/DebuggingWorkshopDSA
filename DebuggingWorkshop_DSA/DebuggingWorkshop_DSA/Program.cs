using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DebuggingWorkshop_DSA
{
    class Program
    {
        static void Main(string[] args)
        {
            DebugMeMathTest.RunAllTests();

            // For Illustrating the viewing of objects in watch window

            Person chuck = new Person("Carlos Ray Norris", 73);

            Console.WriteLine(chuck);
            Console.ReadLine();
        }
    }
}

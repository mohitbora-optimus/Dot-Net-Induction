using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class TestSwitch
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your choice \n 1. VB\n 2. C# \n 3.other choice ");
            int Choice = Convert.ToInt32(Console.ReadLine());

            switch (Choice)
            {
                case 1: Console.WriteLine("\t VB .NET: OOP, multithreading and more!");
                    break;
                case 2: Console.WriteLine("\t Good choice, C# is a fine language.");
                    break;
                case 3: Console.WriteLine("\t Well...good luck with that!");
                    break;
            }
            Console.ReadKey();
        }
    }
}

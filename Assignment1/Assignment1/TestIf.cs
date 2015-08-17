using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class TestIf
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Enter your choice of language :\n 1: VB \n 2. c# \n 3. other");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
                Console.WriteLine("\t VB .NET: OOP, multithreading and more!");
            else if (choice == 2)
                Console.WriteLine("\t Good choice, C# is a fine language.");
            else
                Console.WriteLine("\t Well...good luck with that!");

            Console.ReadKey();
        }
    }
}

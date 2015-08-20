
using System;
using System.Collections;
//using Assignment_11;

namespace CollectionNList2
{
   public class Program
    {
        public static void GetDetails(Vehicle newVehicle)
        {
            Console.WriteLine();
            Random rand = new Random();
            newVehicle.Id = rand.Next(1000, 9999);
            Console.WriteLine();
            Console.Write(" ...... 1. Enter Vehicle Type : \t \t");
            newVehicle.VehicleType = Console.ReadLine();
            Console.WriteLine();
            Console.Write(" ...... 2. Enter Manufacturer Name : \t \t");
            newVehicle.Manufacturer = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine();
        }
       
        static void Main(string[] args)
        {
            ArrayList Vehicle = new ArrayList();
            for (int i = 0; i < 2; i++)
            {
                Vehicle newVehicle = new Vehicle();
                Console.WriteLine("------------------- Enter {0} vehicle details ----------------", i + 1);
                Program.GetDetails(newVehicle);
                Console.WriteLine("------------------------------------------------------------------");

                Vehicle.Add(newVehicle);
            }

            for (int i = 0; i < Vehicle.Count; i++)
            {
 
                Console.WriteLine(Vehicle[i]);
               // Vehicle[i].PrintDetails();
            }
            Console.ReadKey();

        }

        
    }
}

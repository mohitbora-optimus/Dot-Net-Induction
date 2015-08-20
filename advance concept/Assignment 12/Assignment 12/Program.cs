using System;
using System.Collections.Generic;

namespace Assignment_11
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

        public static void Main(string[] args)
        {
            
              VehicleCollection<Vehicle> vehicles = new VehicleCollection<Vehicle>();

            for (int i = 0; i < 2; i++)
            {
                Vehicle newVehicle = new Vehicle();
                Console.WriteLine("------------------- Enter {0} vehicle details ----------------", i + 1);
                Program.GetDetails(newVehicle);
                Console.WriteLine("------------------------------------------------------------------");

                vehicles.Add(newVehicle);
            }
            Console.ReadKey();

            foreach (Vehicle vehicle in vehicles)
            {
                vehicle.PrintDetails();
            }
            Console.WriteLine(" NOW sorting the vehicles according to VehicleId .......\n\n\n press any key to see result \n ");
            vehicles.sort();
            Console.ReadKey();

            foreach (var vehicle in vehicles)
            {
                vehicle.PrintDetails();
            }
            Console.ReadKey();
            Console.WriteLine(" \n\n\n now comparing two Vehicles {0} , {1}", vehicles[0].VehicleType, vehicles[1].VehicleType);
            if (vehicles[0].Equals(vehicles[1]))
                Console.WriteLine(" yes they are equal");
            else
                Console.WriteLine(" no they are not equal");

            Console.ReadKey();
        }
    }
}
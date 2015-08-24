using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomException
{
    class Program 
    {
        static void Main(string[] args)
        {
            Bike firstBike = new Bike("Bike",2050, "New", 190F, "Hero Honda", 2, 3);
            Bicycle secondCycle = new Bicycle("Bicycle",1993, "Racing", 55.66F, "Atlas", 2, 1);
            Truck thirdTruck = new Truck("Truck",2015, "Transport", 80, "Ashok Layland", 8, 100);
            Car newCar = new Car("Car",2014, "Comfort", 15, "Maruti", 100);

            Console.WriteLine(" \n \n increasing speed of cycle");
            for(int i= 0 ; i< 5; i++)
                secondCycle.Acclerate();
            Console.WriteLine(" \n \n increasing speed of Bike");
            for (int i = 0; i < 5; i++)
                firstBike.Acclerate();

            Console.WriteLine("\n \n  increasing speed of Truck");
            for (int i = 0; i < 5; i++)
                thirdTruck.Acclerate();

            Console.WriteLine(" \n \n decreasing speed of car");
            for (int i = 0; i < 10; i++)
                newCar.Deacclerate();

            Console.WriteLine(" \n \n increasing speed of car");
            for (int i = 0; i < 10; i++)
                newCar.Acclerate();

            
            Console.ReadKey();



        }
    }
}

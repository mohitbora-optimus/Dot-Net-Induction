using Assignment9;
using System;

namespace Assignment_9
{
    class Truck : Vehicle
    {
        int _noOfTyres;
        int _di;

        public Truck(int year, string model, float speed, string make, int tyres, int di)
            : base(year, model, speed, make)
        {
            _noOfTyres = tyres;
            _di = di;
        }

        public void ShowDetails()
        {
            Console.WriteLine(" Year of manufactutre {0} ", Year);
            Console.WriteLine(" Model of Truck {0} ", Model);
            Console.WriteLine(" Speed of Truck {0} ", Speed);
            Console.WriteLine(" Make of manufactutre {0} ", make);
            Console.WriteLine(" Tyres in Truck {0} ", _noOfTyres);
            Console.WriteLine("engine {0} cc ", _di);
        }
    }
}

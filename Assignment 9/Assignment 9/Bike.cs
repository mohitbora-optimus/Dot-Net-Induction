using Assignment9;
using System;

namespace Assignment_9
{
    class Bike : Vehicle
    {
        int _noOfTyres;
        int _engine;

        public Bike(int year, string model, float speed, string make, int tyres, int engine)
            : base(year, model, speed, make)
        {
            _noOfTyres = tyres;
            _engine = engine;
        }

        public void ShowDetails()
        {
            Console.WriteLine(" Year of manufactutre {0} ", Year);
            Console.WriteLine(" Model of Bike {0} ", Model);
            Console.WriteLine(" Speed of Bike {0} ", Speed);
            Console.WriteLine(" Make of manufactutre {0} ", make);
            Console.WriteLine(" Tyres in bike {0} ", _noOfTyres);
            Console.WriteLine("engine bike {0} cc ", _engine);
        }
    }

}

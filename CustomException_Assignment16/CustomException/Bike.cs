using System;

namespace CustomException
{
    class Bike : Vehicle
    {
        int _noOfTyres;
        int _engine;

        public Bike(string type,int year, string model, float speed, string make, int tyres, int engine)
            : base(type,year, model, speed, make)
        {
            _noOfTyres = tyres;
            _engine = engine;
        }

        public override void ShowDetails()
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

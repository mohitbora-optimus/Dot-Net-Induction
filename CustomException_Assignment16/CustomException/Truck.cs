using System;

namespace CustomException
{
    class Truck : Vehicle
    {
        int _noOfTyres;
        int _di;

        public Truck(string type,int year, string model, float speed, string make, int tyres, int di)
            : base(type, year, model, speed, make)
        {
            _noOfTyres = tyres;
            _di = di;
        }

        public override void ShowDetails()
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

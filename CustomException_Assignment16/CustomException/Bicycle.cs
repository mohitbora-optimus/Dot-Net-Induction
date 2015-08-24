using System;

namespace CustomException
{
    class Bicycle : Vehicle
    {
        int _noOfTyres;
        int _capacity;

        public Bicycle(string type,int year, string model, float speed, string make, int tyres, int capacity)
            : base(type, year, model, speed, make)
        {
            _noOfTyres = tyres;
            _capacity = capacity;
        }

        public override void ShowDetails()
        {
            Console.WriteLine(" Year of manufactutre {0} ", Year);
            Console.WriteLine(" Model of Bicycle {0} ", Model);
            Console.WriteLine(" Speed of Bicycle {0} ", Speed);
            Console.WriteLine(" Make of manufactutre {0} ", make);
            Console.WriteLine(" capacity of bicycle {0} ", _capacity);
            Console.WriteLine(" Number of Tyres in bicycle {0} ", _noOfTyres);
        }
    }

}

using Assignment9;
using System;

namespace Assignment_9
{
    class Bicycle :Vehicle
    {
        int _noOfTyres;
        int _capacity;

        public Bicycle(int year, string model, float speed, string make, int tyres, int capacity)
            : base(year, model, speed, make)
        {
            _noOfTyres = tyres;
            _capacity = capacity;
        }

        public void ShowDetails()
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

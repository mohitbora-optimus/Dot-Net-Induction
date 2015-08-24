using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomException
{
    class Car :Vehicle
    {
        private int _temperatuer;

         public Car(string type,int year, string model, float speed, string make, int Temperature)
            : base(type, year, model, speed, make)
        {
            _temperatuer = Temperature;
        }

         public override void ShowDetails()
         {
             Console.WriteLine(" Year of manufactutre {0} ", Year);
             Console.WriteLine(" Model of Car {0} ", Model);
             Console.WriteLine(" Speed of Car {0} ", Speed);
             Console.WriteLine(" Make of manufactutre {0} ", make);
             Console.WriteLine(" Temperature of Car {0} ", _temperatuer);
            
         }


    }
}

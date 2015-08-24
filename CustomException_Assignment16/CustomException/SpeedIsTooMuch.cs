using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomException
{
    public class SpeedIsTooMuch :Exception
    {
        public SpeedIsTooMuch() : base("speed is too much")
    {}
    }


    public class IsCarDead : Exception
    {
        public IsCarDead() : base(" Car is overheated") { }
    }

    public class NegativeSpeed : Exception
    {
        public NegativeSpeed() : base(" Speed is negative"){}
    }
}

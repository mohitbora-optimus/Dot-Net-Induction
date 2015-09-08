using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterClass
{
    class Target
    {
       public virtual void RequestAdaptee()
        {
            //
        }
    }

    class Adapter: Target
    {
        private Adaptee _adaptee = new Adaptee();
        public override void RequestAdaptee()
        {
            _adaptee.Request();
        }
    }

    class Adaptee
    {
        public void Request()
        {
            Console.WriteLine("Adaptee Called By adapter");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Target target = new Adapter();
            target.RequestAdaptee();
            Console.ReadKey();
        }
    }
}

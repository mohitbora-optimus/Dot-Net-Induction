using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class SingletonSample
    {
        private static SingletonSample _singletonObject;

        private SingletonSample()
        {
            // private constructor
        }

        public static SingletonSample GetInstance()
        {
           Object lockingObject = new Object();

            if (_singletonObject == null)
            {
                if (lockingObject == null)
                {
                    _singletonObject = new SingletonSample();
                }
            }
            return _singletonObject;
        }

        public void Display()
        {
            Console.WriteLine("This is Display function....");
        }

        static void Main(string[] args)
        {
            SingletonSample Instance = SingletonSample.GetInstance();
            Instance.Display();
            Console.ReadKey();
        }
    }
}

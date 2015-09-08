using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    public enum Manufacturer
    {
        Nokia,
        Samsung
    }
    
    public interface IDumbProduct
    {
        string Name();
    }

    public interface ISmartProduct
    {
        string Name();
    }

    public class Asha : IDumbProduct
    {
        public string Name()
        {
            return "Asha";
        }
    }

    public class Primo : IDumbProduct
    {
        public string Name()
        {
            return "Primo";
        }
    }

    public class Lumia : ISmartProduct
    {
        public string Name()
        {
            return "Lumia";
        }
    }

    public class Galaxy : ISmartProduct
    {
        public string Name()
        {
            return "Galaxy";
        }
    }

    public interface IPhoneFactory
    {
        ISmartProduct GetSmart();
        IDumbProduct GetDumb();
    }

    public class Samsung : IPhoneFactory
    {
        public ISmartProduct GetSmart()
        {
            return new Galaxy();
        }

        public IDumbProduct GetDumb()
        {
            return new Primo();
        }
    }

    public class Nokia : IPhoneFactory
    {
        public ISmartProduct GetSmart()
        {
            return new Lumia();
        }

        public IDumbProduct GetDumb()
        {
            return new Asha();
        }
    }

    public class PhoneChecker
    {
        private Manufacturer _userChoice;
        private IPhoneFactory _factory;

        public PhoneChecker(Manufacturer choice)
        {
            _userChoice = choice;
        }

        public void CheckProduct()
        {
            switch (_userChoice)
            {
                case Manufacturer.Nokia:
                    {
                        _factory = new Nokia();
                        break;
                    }
                case Manufacturer.Samsung:
                    {
                        _factory = new Samsung();
                        break;
                    }
            }

            Console.WriteLine(_factory.ToString() + " Smart Phone : " + _factory.GetSmart().Name() + "\n  Dumb Phone :" + _factory.GetDumb().Name());
        }

        public static void Main(string[] args)
        {
            PhoneChecker phoneChecker = new PhoneChecker(Manufacturer.Nokia);
            phoneChecker.CheckProduct();

            phoneChecker = new PhoneChecker(Manufacturer.Samsung);
            phoneChecker.CheckProduct();
            Console.ReadKey();
        }
    }
}

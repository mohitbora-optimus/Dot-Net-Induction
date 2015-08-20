using System;
using System.Collections;

namespace CollectionNList2
{
    //public enum CountVehicle { First = 1, Second, Third, Fourth, Fifth, Sixth, Seventh, Eighth, Ninth, Tenth };

    public class Vehicle : IComparable<Vehicle>, IEquatable<Vehicle>
    {
        private string _vehicleType;
        private int _vehicleId;
        private string _manufacturer;

        public string VehicleType
        {
            get
            {
                return _vehicleType;
            }
            set
            {
                _vehicleType = value;
            }
        }

        public int Id
        {
            get
            {
                return _vehicleId;
            }
            set
            {
                _vehicleId = value;
            }
        }

        public string Manufacturer
        {
            get
            {
                return _manufacturer;
            }
            set
            {
                _manufacturer = value;
            }
        }


        public void PrintDetails()
        {
            Console.WriteLine("....... vehicle details .......");
            Console.WriteLine(" ... 1. Vehicle Id : \t \t{0}", _vehicleId);
            Console.WriteLine(" ... 2. Vehicle Type : \t \t {0}", _vehicleType);
            Console.WriteLine(" ... 3. Manufacturer Name : \t \t {0}", _manufacturer);
            Console.WriteLine("\n");

        }

        public int CompareTo(Vehicle obj)
        {
            // Vehicle v = (Vehicle)obj;
            return ((this.Id == obj.Id) ? 0 : ((this.Id > obj.Id) ? 1 : -1));

        }

        public bool Equals(Vehicle obj)
        {
            if ((this.Id == obj.Id) && (string.Compare(obj.Manufacturer, this.Manufacturer) == 0) && (this.VehicleType == obj.VehicleType))
                return true;
            else
                return false;
        }

        public override String ToString()
        {
            return String.Format("vehicle Id:{0} is of {1} type manufactured by {2}", Id, VehicleType, Manufacturer);
        }
    }
}

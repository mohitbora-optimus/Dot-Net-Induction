using System.Collections.Generic;

namespace Assignment_11
{
    public class VehicleCollection<Vehicle> : IEnumerable<Vehicle>
    {
        List<Vehicle> myList = new List<Vehicle>();
              
        
         public void Add(Vehicle obj)
        {
            myList.Add(obj);
        }

        public IEnumerator<Vehicle> GetEnumerator()
        {
            return myList.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return myList.GetEnumerator();
        }

        public void sort()
        {
            myList.Sort();
        }

        public Vehicle this[int index]
        {
            get
            {
                return myList[index];
            }

        }

       
    }
}

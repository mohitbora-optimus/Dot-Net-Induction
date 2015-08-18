using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment11
{
    class CollegeStudent : Student
    {
        private string _collegeName;

        private string CollegeName
        {
            get
            {
                return _collegeName;
            }
            set
            {
                _collegeName = value;
            }
        }
        public void GetDetails()
        {
            Console.WriteLine("Enter The Detials of College student: ");
            Console.Write("Enter Name \t : ");
            Name = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Enter Age \t : ");
            Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Enter Roll Number \t : ");
            RollNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Enter College \t : ");
            _collegeName = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Enter Affilation \t : ");
            Affilation = Console.ReadLine();
            Console.WriteLine();
        }
        public void PutDetails()
        {
            Console.WriteLine(" Detials of College student: ");
            Console.WriteLine(" Name: \t{0} ", name);
            Console.WriteLine(" Age: \t {0}", age);
            Console.WriteLine(" Roll Number: \t {0}  ", RollNumber);
            Console.WriteLine(" College :\t {0} ", CollegeName);
            Console.WriteLine(" Affilation :\t  {0}", affilation);
        }
    }

}
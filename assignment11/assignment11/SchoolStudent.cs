using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment11
{
    class SchoolStudent: Student
    {
        private string _schoolName;

        private string SchoolName
        {
            get
            {
                return _schoolName;
            }
            set
            {
                _schoolName = value;
            }
        }

        public void GetDetails()
        {
            Console.WriteLine("Enter The Detials of School student: ");
            Console.WriteLine("Enter Name \t : ");
            Name = Console.ReadLine();
            Console.WriteLine("Enter Age \t : ");
            Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Roll Number \t : ");
            RollNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter School \t : ");
            _schoolName = Console.ReadLine();
            Console.WriteLine("Enter Affilation \t : ");
            Affilation = Console.ReadLine();

        }
        public void PutDetails()
        {
            Console.WriteLine(" Detials of School student: ");
            Console.WriteLine(" Name \t :{0} ", name);
            Console.WriteLine(" Age \t : {0} ", age);
            Console.WriteLine(" Roll Number: \t  {0}  ", RollNumber);
            Console.WriteLine(" College :\t {0}  ", SchoolName);
            Console.WriteLine(" Affilation: \t {0}  ", affilation);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment11
{
    class Program
    {
        public static void Main(string[] args)
        {
            CollegeStudent collegeStudent = new CollegeStudent();
            SchoolStudent schoolStudent = new SchoolStudent();
            Console.WriteLine("\t\twhose detail you want to insert : \n \t 1. School Student \n \t 2. College Student ");
            int n = Convert.ToInt32(Console.ReadLine());
            switch (n)
            {
                case 1:
                   
                    collegeStudent.GetDetails();
                    break;

                case 2:
                    
                    schoolStudent.GetDetails();
                    break;
            }

            Console.WriteLine("\t\twhose detail you want to See : \n \t 1. School Student \n \t 2. College Student ");
             n = Convert.ToInt32(Console.ReadLine());
            switch (n)
            {
                case 1:
                    collegeStudent.PutDetails();
                    break;

                case 2:
                    schoolStudent.PutDetails();
                    break;
            }

            Console.ReadKey();
        }

    }
}

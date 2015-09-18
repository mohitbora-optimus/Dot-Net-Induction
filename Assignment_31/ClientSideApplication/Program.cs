using StudentService1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ClientSideApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentService1.Service stu = new StudentService1.Service();
            Console.WriteLine(DateTime.Now.ToString());
            Console.WriteLine("Enter Roll Number");
            int rollNumber = Convert.ToInt32(Console.ReadLine());
            try
            {
                Student student = stu.GetStudentDetails(rollNumber);
                Console.WriteLine("Student Details \n\n");
                Console.WriteLine("1. Name : {0}", student.Name);
                Console.WriteLine("2. RollNumber : {0}", student.RollNumber);
                Console.WriteLine("3. Grade : {0}", student.Grade);
            }
            catch (Exception)
            {
                Console.WriteLine("Student Not Found");

            }
            Console.ReadKey();
        }
    }
}

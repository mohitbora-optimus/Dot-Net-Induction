using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentService1
{
    public class Student
    {
        private int _rollNumber;
        private string _name;
        private string _grade;

        public string Grade
        {
            get { return _grade; }
            set { _grade = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int RollNumber
        {
            get { return _rollNumber; }
            set { _rollNumber = value; }
        }

 
    }
}
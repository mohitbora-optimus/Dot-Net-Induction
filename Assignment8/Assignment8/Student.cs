using System;


namespace Assignment8
{
    class Student
    {

        private string _name;
        private int _rollNumber;
        private string _address;
        private int _marks;
        private int _enrollment;

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }

        public int RollNumber
        {
            get
            {
                return _rollNumber;
            }
            set
            {
                _rollNumber = value;
            }
        }

        public string Address
        {
            get
            {
                return _address;
            }
            set
            {
                _address = value;
            }
        }

        public int Marks
        {
            get
            {
                return _marks;
            }

            set
            {
                _marks = value;
            }
        }

        public int EnrollmentNumber
        {
            get
            {
                return _enrollment;
            }
        }
        public Student()
        {

        }

        public  Student(string name, int rollNumber, string address, int marks)
        {
            this._name = name;
            this._rollNumber = rollNumber;
            this._address = address;
            this._marks = marks;

            Random ran = new Random();
            _enrollment = ran.Next(100, 10000);
        }

        public void PrintDetails()
        {
             Console.WriteLine("\n \t \t \t WELCOME \n \n ");

            
            Console.WriteLine("\t \t \t Name of student : {0} \t \n", _name);
            Console.WriteLine("\t \t \t Roll Number of student : {0} \t \n",_rollNumber);
            Console.WriteLine("\t \t \t Address of student : {0} \t \n", _address);
            Console.WriteLine("\t \t \t Marks of student : {0} \t \n", _marks);
            Console.WriteLine("\t \t \t Enrollment number is : {0} \t \n", _enrollment);
            Console.WriteLine();
        }
    }
}
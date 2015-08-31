using BussinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentClass
{
    public class Student
    {
        private string _name;
        private int _enrollmentNumber;
        private int _marks;
        private int _age;
        private string _gender;

        private StudentToDB _studentToDB;

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

        public int EnrollmentNumber
        {
            get
            {
                return _enrollmentNumber;
            }
            set
            {
                _enrollmentNumber = value;
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

        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                _age = value;
            }
        }

        public string Gender
        {
            get
            {
                return _gender;
            }
            set
            {
                _gender = value;
            }
        }

        public Student(string filePath)
        {
            UtilityClass.boolLoadFromCSV(filePath);
        }

        public Student() { }

        public void AddStudent(string connectionString, string name, int enrollmentnumber, int marks, int age, string gender)
        {
            _studentToDB = new StudentToDB(connectionString);
            _studentToDB.AddNewStudent(name, enrollmentnumber, marks, age, gender);
        }

        public void writeToCsv(string connectionString)
        {
            _studentToDB = new StudentToDB(connectionString);
            _studentToDB.WriteToCsvFile();
        }
    }
}

using StudentEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace StudentService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in both code and config file together.
    public class Service : IService
    {
        StudentEntities _student;

        public Student GetStudentDetails(int rollNumber)
        {
            _student = new StudentEntities();
            Student student = new Student();
            StudentsRecord studentRecord =  _student.StudentsRecords.Find(rollNumber);

            {
                student.Name = studentRecord.Name;
                student.Grade = studentRecord.Grade;
                student.RollNumber = studentRecord.RollNumber;
            }
            return student;
        }
    }
}

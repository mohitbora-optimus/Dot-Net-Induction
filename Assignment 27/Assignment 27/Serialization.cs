using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Assignment_27
{  [Serializable]
    public class Student
    {
        public string Name;
        public int RollNo;
        public int TotalMarks;
    [NonSerialized]
        public readonly char grade;

        public char ReturnsGrade(int marks)
        {
               if (TotalMarks > 60)
                    return ('D');
                else if (TotalMarks >= 60 && TotalMarks < 80)
                    return ('C');
                else if (TotalMarks >= 80 && TotalMarks < 90)
                    return ('B');
                else if (TotalMarks >= 90 && TotalMarks < 100)
                    return ('A');
                else
                    return ('F');
            
        }

        public void saveXML(string fileName)
        {
            using (var stream = new FileStream(fileName, FileMode.Create))
            {
                XmlSerializer xml = new XmlSerializer(typeof(Student));
                xml.Serialize(stream, this);
            }
        }

        public static Student LoadXML(string fileName)
        {
            using (var stream = new  FileStream(fileName, FileMode.Open))
            {
                var xml = new XmlSerializer(typeof(Student));
                return (Student)xml.Deserialize(stream);
               
            }
        }

        public void SaveBinary(string fileName)
        {
           using( var stream = new FileStream(fileName,FileMode.Create))
           {
               BinaryFormatter formatter = new BinaryFormatter();
               formatter.Serialize(stream, this);
           }
        }

        public Student LoadBinary(string fileName)
        {
            using (var stream = new FileStream(fileName, FileMode.Open))
            {
                BinaryFormatter formatter = new BinaryFormatter();
              return  (Student)formatter.Deserialize(stream);
            }
        }

        public void SaveSoap(string fileName)
        {
            using (var stream = new FileStream(fileName, FileMode.Create))
            {
                SoapFormatter formatter = new SoapFormatter();
                formatter.Serialize(stream, this);
            }
        }

        public Student LoadSoap(string fileName)
        {
            using (var stream = new FileStream(fileName, FileMode.Open))
            {
                SoapFormatter formatter = new SoapFormatter();
                return (Student)formatter.Deserialize(stream);
            }
        }
    }

    public class Serialization
    {
        public static void  XmlSerial()
        {
            Student student = new Student();
            student.Name = "Ajay";
            student.RollNo = 55;
            student.TotalMarks = 50;
            Console.WriteLine(student.ReturnsGrade(student.TotalMarks));
            Console.ReadKey();
            student.saveXML("icalibrator.xml");
            Student studentsDetails = Student.LoadXML("icalibrator.xml");
            Console.WriteLine(studentsDetails.Name);
            Console.WriteLine(studentsDetails.RollNo);
            Console.WriteLine(studentsDetails.TotalMarks);

            Console.ReadKey();
        }

        public static void BinarySerial()
        {
            Student student = new Student();
            student.Name = "Ajay";
            student.RollNo = 55;
            student.TotalMarks = 50;
            student.SaveSoap("binary1.bin");
            Student studentsDetails = student.LoadSoap("binary1.bin");
            Console.WriteLine(studentsDetails.Name);
            Console.WriteLine(studentsDetails.RollNo);
            Console.WriteLine(studentsDetails.TotalMarks);
        }

        public static void Soapserial()
        {
            Student student = new Student();
            student.Name = "Ajay";
            student.RollNo = 55;
            student.TotalMarks = 50;
            student.SaveSoap("soap.bin");
            Student studentsDetails = student.LoadSoap("soap.bin");
            Console.WriteLine(studentsDetails.Name);
            Console.WriteLine(studentsDetails.RollNo);
            Console.WriteLine(studentsDetails.TotalMarks);
        }

        public static void Main(string[] args)
        {
            XmlSerial();
            BinarySerial();
            Soapserial();

            Console.ReadKey();

        }
    }
}

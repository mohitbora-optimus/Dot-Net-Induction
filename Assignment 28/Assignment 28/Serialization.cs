using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Assignment_27
{
    [Serializable]
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

        public void SaveXML(string fileName, List<Student> myList)
        {
            using (var stream = new FileStream(fileName, FileMode.Append))
            {
                XmlSerializer xml = new XmlSerializer(typeof(List<Student>));
                xml.Serialize(stream, myList);
            }
        }

        public List<Student> LoadXML(string fileName)
        {
            using (var stream = new FileStream(fileName, FileMode.Open))
            {
                XmlSerializer serializer = new
    XmlSerializer(typeof(List<Student>));

                // A FileStream is needed to read the XML document.
                XmlReader reader = XmlReader.Create(stream);

                // Declare an object variable of the type to be deserialized.
                List<Student> students = null;

                // Use the Deserialize method to restore the object's state.
                students = (List<Student>)serializer.Deserialize(reader);
                return students;
            }
        }

        public void SaveBinary(string fileName, List<Student> myList)
        {
            using (var stream = new FileStream(fileName, FileMode.Append))
            {
                BinaryFormatter binary = new BinaryFormatter();
                binary.Serialize(stream, myList);
            }
        }

        public List<Student> LoadBinary(string fileName)
        {
            List<Student> student;
            using (var stream = File.Open(fileName, FileMode.Open))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                student = (List<Student>)formatter.Deserialize(stream);
            }
            return student;
        }

        public void SaveSoap(string fileName, List<Student> myList)
        {
            using (var stream = new FileStream(fileName, FileMode.Append))
            {
                SoapFormatter xml = new SoapFormatter();
                xml.Serialize(stream, myList.ToArray());
            }
        }

        public Student[] LoadSoap(string fileName)
        {
            Student[] student;
            using (var stream = new FileStream(fileName, FileMode.Open))
            {
                SoapFormatter formatter = new SoapFormatter();
                student = (Student[])formatter.Deserialize(stream);
            }
            return student;
        }
    }

    public class Serialization
    {
        public static void XmlSerial()
        {
            List<Student> students = new List<Student>()
            {
                new Student() {
                    Name = "Ajay",
                    RollNo = 55,
                    TotalMarks = 50
                },
                new Student() {
                    Name = "Vijay",
                    RollNo = 56,
                    TotalMarks = 78
                },
                new Student() {
                    Name = "Vikram",
                    RollNo = 57,
                    TotalMarks = 95
                }
            };


            students[0].SaveXML("icalibrator.xml", students);

            List<Student> myList = students[0].LoadXML("icalibrator.xml");

            foreach (Student student in myList)
            {
                Console.WriteLine(student.Name);
                Console.WriteLine(student.RollNo);
                Console.WriteLine(student.TotalMarks);
            }
            Console.ReadKey();
        }

        public static void BinarySerial()
        {
            List<Student> students = new List<Student>()
            {
                new Student() {
                    Name = "Ajay",
                    RollNo = 55,
                    TotalMarks = 50
                },
                new Student() {
                    Name = "Vijay",
                    RollNo = 56,
                    TotalMarks = 78
                },
                new Student() {
                    Name = "Vikram",
                    RollNo = 57,
                    TotalMarks = 95
                }
            };

            students[0].SaveBinary("binary1.bin", students);

            List<Student> myList = students[0].LoadBinary("binary1.bin");

            foreach (Student studentDetails in myList)
            {
                Console.WriteLine(studentDetails.Name);
                Console.WriteLine(studentDetails.RollNo);
                Console.WriteLine(studentDetails.TotalMarks);
            }

        }

        public static void Soapserial()
        {
            List<Student> students = new List<Student>()
            {
                new Student() {
                    Name = "Ajay",
                    RollNo = 55,
                    TotalMarks = 50
                },
                new Student() {
                    Name = "Vijay",
                    RollNo = 56,
                    TotalMarks = 78
                },
                new Student() {
                    Name = "Vikram",
                    RollNo = 57,
                    TotalMarks = 95
                }
            };

            students[0].SaveSoap("soap.bin", students);


            Student[] stu = students[0].LoadSoap("soap.bin");

            foreach (Student studentDetails in stu)
            {
                Console.WriteLine(studentDetails.Name);
                Console.WriteLine(studentDetails.RollNo);
                Console.WriteLine(studentDetails.TotalMarks);
            }
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


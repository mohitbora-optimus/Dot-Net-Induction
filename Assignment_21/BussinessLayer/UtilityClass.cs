using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SqlClient;


namespace BussinessLayer
{
    public class StudentModel
    {
        private string _name;
        private int _enrollmentNumber;
        private int _marks;
        private int _age;
        private string _gender;

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



    }

    public static class UtilityClass
    {
        private static StudentToDB _studentToDBObject;

        private static string _connectionString = @"Data Source=OPTIMUS-150\SQLEXPRESS;Initial Catalog=studentRecords;Integrated Security=True";

        public static void boolLoadFromCSV(string fileName)
        {
            List<StudentModel> studentModel = new List<StudentModel>();
            StudentModel tempStudent = new StudentModel();

            _studentToDBObject = new StudentToDB(_connectionString);

            using (var fileReader = new StreamReader(fileName))
            {
                string line;
                string[] details;

                while ((line = fileReader.ReadLine()) != null)
                {
                    details = line.Split(',');
                    tempStudent.Name = details[0];
                    tempStudent.EnrollmentNumber = Convert.ToInt32(details[1]);
                    tempStudent.Marks = Convert.ToInt32(details[2]);
                    tempStudent.Age = Convert.ToInt32(details[3]);
                    tempStudent.Gender = details[4];

                    studentModel.Add(tempStudent);
                }
            }

            _studentToDBObject.InsertStudent(studentModel);
        }
    }

    public class StudentToDB
    {
        private string _connectionString;

        public StudentToDB(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void InsertStudent(List<StudentModel> studentCollection)
        {
            SqlConnection connection = new SqlConnection(_connectionString);

            foreach (StudentModel studentModelObject in studentCollection)
            {
                string query = string.Format("INSERT INTO Student(Name, EnrollmentNumber, Marks, Age, Gender) VALUES('{0}',{1}, {2},{3},'{4}')", studentModelObject.Name, studentModelObject.EnrollmentNumber, studentModelObject.Marks, studentModelObject.Age, studentModelObject.Gender);
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                command.ExecuteNonQuery();
            }

            connection.Close();
        }

        public void AddNewStudent(string name, int rollnumber, int marks, int age, string gender)
        {
            SqlConnection connection = new SqlConnection(_connectionString);
            connection.Open();
            string query = string.Format("Insert into Student(Name, EnrollmentNumber, Marks, Age, Gender) values('{0}', {1}, {2}, {3}, '{4}')", name, rollnumber, marks, age, gender);
            SqlCommand command = new SqlCommand(query, connection);

            command.ExecuteNonQuery();
            connection.Close();
        }

        public void WriteToCsvFile()
        {
            FileStream writerObject = File.Create("C:\\hack\\Write.csv");

            writerObject.Close();

            SqlConnection connection = new SqlConnection(_connectionString);
            connection.Open();
            string query = @"select * from Student";
            SqlCommand command = new SqlCommand(query, connection);

            SqlDataReader reader = command.ExecuteReader();

            StudentModel studentModelObject;
            using (StreamWriter writer = new StreamWriter("C:\\hack\\Write.csv"))
            {
                while (reader.Read())
                {
                    studentModelObject = new StudentModel();
                    studentModelObject.Name = reader["Name"].ToString();
                    studentModelObject.EnrollmentNumber = Convert.ToInt32(reader["EnrollmentNumber"].ToString());
                    studentModelObject.Marks = Convert.ToInt32(reader["Marks"].ToString());
                    studentModelObject.Age = Convert.ToInt32(reader["Age"].ToString());
                    studentModelObject.Gender = reader["Gender"].ToString();


                    writer.Write(studentModelObject.Name + ",");
                    writer.Write(studentModelObject.EnrollmentNumber + ",");
                    writer.Write(studentModelObject.Marks + ",");
                    writer.Write(studentModelObject.Age + ",");
                    writer.Write(studentModelObject.Gender);
                }
            }
            connection.Close();
        }

    }
}

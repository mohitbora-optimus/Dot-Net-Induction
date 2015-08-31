using System;
using System.Data.SqlClient;
using System.Management;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace StudentDataHandler
{
    public class StudentModel
    {
        private string _name;
        private int _enrollmentNumber;
        private int _streamId;
        private int _stateId;
        private int _marks;
        private string _state;
        private string _stream;

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

        public int StreamId
        {
            get
            {
                return _streamId;
            }
            set
            {
                _streamId = value;
            }
        }

        public int StateId
        {
            get
            {
                return _stateId;
            }
            set
            {
                _stateId = value;
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

        public string State
        {
            get
            {
                return _state;
            }
            set
            {
                _state = value;
            }
        }

        public string Stream
        {
            get
            {
                return _stream;
            }
            set
            {
                _stream = value;
            }
        }

    }

    public class StudentDBService
    {
        private string _connectionString;
        private StudentModel _studentModel;

        public StudentDBService(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void AddingToStudentRecord(string name, int rollnumber, int streamId, int marks, int stateId, string state, string stream)
        {
            SqlConnection studentRecord = new SqlConnection(_connectionString);
            studentRecord.Open();
            SqlCommand command;
            string query = string.Format("select * from state where stateId={0}", stateId);
            command = new SqlCommand(query, studentRecord);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read() == null)
            {
                string cmdStateTable = string.Format("INSERT INTO State(StateId, StateName) Values({0},'{1}')", stateId, state);
                command = new SqlCommand(cmdStateTable, studentRecord);
                command.ExecuteNonQuery();
            }

            reader.Close();

            query = string.Format("select * from Streams where streamId={0}", streamId);
            command = new SqlCommand(query, studentRecord);
            reader = command.ExecuteReader();
            if (reader.Read() == null)
            {
                string cmdStreamsTable = string.Format("INSERT INTO Streams(StreamId, Stream) values({0},'{1}')", streamId, stream);
                command = new SqlCommand(cmdStreamsTable, studentRecord);
                command.ExecuteNonQuery();
            }
            reader.Close();
            string cmdStudentTable = string.Format("INSERT INTO StudentDetails(Name, EnrollmentNumber,StreamId,Marks,StateId) VALUES('{0}', {1}, {2}, {3}, {4})", name, rollnumber, streamId, marks, stateId);
            command = new SqlCommand(cmdStudentTable, studentRecord);
            command.ExecuteNonQuery();

            studentRecord.Close();
        }

        public bool FindStudent(int studentEnrollmentNumber)
        {
            SqlConnection studentRecord = new SqlConnection(_connectionString);
            string cmd = string.Format("select * from StudentDetails where Enrollmentnumber = {0}", studentEnrollmentNumber);
            SqlCommand command = new SqlCommand(cmd, studentRecord);
            studentRecord.Open();
            SqlDataReader readerObject = command.ExecuteReader();

            if (readerObject.Read() == true)
            {
                return true;
            }
            else
                return false;
        }

        public StudentModel GetDetails(int studentEnrollmentNumber)
        {
            SqlConnection studentRecord = new SqlConnection(_connectionString);

            string cmd = string.Format("SELECT * FROM state join StudentDetails on ( state.StateId = StudentDetails.StateId) join Streams on (StudentDetails.StreamId = Streams.StreamId) WHERE EnrollmentNumber  = {0} ", studentEnrollmentNumber);

            SqlCommand command = new SqlCommand(cmd, studentRecord);
            studentRecord.Open();

            SqlDataReader readerObject = command.ExecuteReader();
            if (readerObject.Read())
            {
                _studentModel = new StudentModel();

                _studentModel.EnrollmentNumber = Convert.ToInt32(readerObject["EnrollmentNumber"]);
                _studentModel.Name = (string)readerObject["Name"];
                _studentModel.State = (string)readerObject["StateName"];
                _studentModel.Stream = (string)readerObject["Stream"];
                _studentModel.StateId = Convert.ToInt32(readerObject["StateId"]);
                _studentModel.StreamId = Convert.ToInt32(readerObject["StreamId"]);
                return _studentModel;
            }

            return null;
        }

        public void UpdateRecord(string name, int enrollmentNumber, int streamId, int marks, int stateId, string state, string stream)
        {
            SqlConnection connection = new SqlConnection(_connectionString);
            connection.Open();
            string query = string.Format("Update state set StateName={0}", state);
            SqlCommand command = new SqlCommand(query, connection);
            command.ExecuteNonQuery();

            query = string.Format("Update Streams set stream = '{0}' where StreamId = {1}", stream, streamId);
            command = new SqlCommand(query, connection);
            command.ExecuteNonQuery();

            query = string.Format("update StudentDetails set Name = '{0}', Stream = {1}, Marks={2}, StateName={3} where EnrollmentNumber = {4}", name, stream, marks, state, enrollmentNumber);
            command = new SqlCommand(query, connection);
            command.ExecuteNonQuery();

            connection.Close();
        }


        public SqlDataReader ShowAll(int stream)
        {
            SqlConnection connection = new SqlConnection(_connectionString);
            connection.Open();
            string query = string.Format("select Name from StudentDetails where streamId = {0}", stream);
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            return reader;
        }
    }

}


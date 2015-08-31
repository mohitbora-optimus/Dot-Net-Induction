using StudentDataHandler;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentClass
{
    public class Student
    {
        private StudentDBService _studentDBService;
        private StudentModel _studentModel;
        private string connectionString;

        private string _name;
        private int _enrollmentNumber;
        private int _streamId;
        private int _stateId;
        private int _marks;
        private string _state;
        private string _stream;

        public Student(String connectionString)
        {
            this.connectionString = connectionString;
            _studentDBService = new StudentDBService(connectionString);
        }

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

        public void AddStudent(string name, int rollnumber, int streamId, int marks, int stateId, string state, string stream)
        {
            _studentDBService.AddingToStudentRecord(name, rollnumber, streamId, marks, stateId, state, stream);
        }

        public void UpdateStudent(string name, int enrollmentNumber, int streamId,int marks,int stateId, string state, string stream )
        {
            _studentDBService.UpdateRecord(name, enrollmentNumber, streamId, marks, stateId, state, stream);
        }

        public void GetDetails(int studentEnrollmentNumber)
        {
            _studentModel = _studentDBService.GetDetails(studentEnrollmentNumber);

            if (_studentModel != null)
            {
                //Student storeValue = new Student();
                this._enrollmentNumber = _studentModel.EnrollmentNumber;
                this._name = _studentModel.Name;
                this._marks = _studentModel.Marks;
                this._streamId = _studentModel.StreamId;
                this._stateId = _studentModel.StateId;
                this._state = _studentModel.State;
                this._stream = _studentModel.Stream;
            }
        }

        public bool SearchStudent(int studentEnrollmentNumber)
        {
            if (_studentDBService.FindStudent(studentEnrollmentNumber))
                return true;
            else
                return false;
        }

        public List<string> GetAllStateName()
        {
            List<string> states = UtilityFunctions.GetAllStateName();
            return states;           
        }

        public List<string> GetAllStreamName()
        {
            List<string> streams = UtilityFunctions.GetAllStreamName();
            return streams;
        }

        public List<int> GetAllStateId()
        {
            List<int> stateId = UtilityFunctions.GetAllStateId();
            return stateId;
        }

        public List<int> GetAllStreamId()
        {
            List<int> streamId = UtilityFunctions.GetAllStreamId();
            return streamId;
        }

        public SqlDataReader ShowAll(int stream)
        {
           return _studentDBService.ShowAll(stream);
        }
    }
}

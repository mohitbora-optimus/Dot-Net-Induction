using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDataHandler
{
    public static class UtilityFunctions
    {
        private static string _connectionString = "Data Source=OPTIMUS-150\\SQLEXPRESS;Initial Catalog=StudentRecord;Integrated Security=True";

        public static Dictionary<int, string> GetAllStreams()
        {
            var streams = new Dictionary<int, string>();

            var connection = new SqlConnection(_connectionString);
            connection.Open();

            var query = string.Format("SELECT StreamId, Stream from Streams");
            var command = new SqlCommand(query, connection);
            var reader = command.ExecuteReader();

            while (reader.Read())
            {
                streams.Add(int.Parse(reader["StreamId"].ToString()), reader["Stream"].ToString());
            }
            return streams;
        }

        public static List<string> GetAllStudents(int streamID)
        {
            var studentList = new List<string>();
            var connection = new SqlConnection(_connectionString);
            connection.Open();

            var query = string.Format("Select Name from StudentDetails");
            var command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                studentList.Add(reader["Name"].ToString());

            }
            return studentList;
        }

        public static Dictionary<int, string> GetAllStates()
        {
            Dictionary<int, string> states = new Dictionary<int, string>();

            SqlConnection connection = new SqlConnection(_connectionString);
            string query = string.Format("SELECT StateId, StateName from State");
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                states.Add(int.Parse(reader["StateId"].ToString()), reader["state"].ToString());
            }

            return states;
        }

        public static string GetStateName(int stateID)
        {
            SqlConnection connection = new SqlConnection(_connectionString);
            connection.Open();
            string query = string.Format("SELECT StateName from State Where StateId = {0}", stateID);

            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                return reader["StateName"].ToString();
            }
            return null;
        }

        public static string GetStreamName(int streamID)
        {
            SqlConnection connection = new SqlConnection(_connectionString);
            connection.Open();
            string query = string.Format("SELECT StateName from Streams Where StreamId = {0}", streamID);

            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                return reader["StreamName"].ToString();
            }
            return null;
        }

        public static List<string> GetAllStreamName()
        {
            List<string> stream = new List<string>();

            SqlConnection connection = new SqlConnection(_connectionString);
            connection.Open();

            var query = string.Format("select Stream from Streams ");
            SqlCommand command = new SqlCommand(query, connection);

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                stream.Add(reader["Stream"].ToString());
            }
            return stream;
        }

        public static List<string> GetAllStateName()
        {
            List<string> states = new List<string>();

            SqlConnection connection = new SqlConnection(_connectionString);
            connection.Open();

            var query = string.Format("select StateName from State ");
            SqlCommand command = new SqlCommand(query, connection);

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                states.Add(reader["StateName"].ToString());
            }
            return states;
        }

        public static List<int> GetAllStateId()
        {
            SqlConnection connection = new SqlConnection(_connectionString);
            List<int> stateId = new List<int>();
            connection.Open();
            string query = string.Format("SELECT StateId from State ");
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                stateId.Add(int.Parse(reader["StateId"].ToString()));
            }
            return stateId;
        }

        public static List<int> GetAllStreamId()
        {
            SqlConnection connection = new SqlConnection(_connectionString);
            List<int> streamId = new List<int>();
            connection.Open();
            string query = string.Format("SELECT StreamId from Streams");
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                streamId.Add(int.Parse(reader["StreamId"].ToString()));
            }
            return streamId;
        }

    }  
}

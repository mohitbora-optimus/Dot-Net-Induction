using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCFDemo
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IStudent
    {
        [OperationContract]
        Student PrintStudentDetails(int value);
        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class Student
    {
        private string _name;

        private int _rollNumber;

        private string _grade;

        [DataMember]
        public string Grade
        {
            get { return _grade; }
            set { _grade = value; }
        }

        [DataMember]
        public int RollNumber
        {
            get { return _rollNumber; }
            set { _rollNumber = value; }
        }

        [DataMember]
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        
       

    }
}

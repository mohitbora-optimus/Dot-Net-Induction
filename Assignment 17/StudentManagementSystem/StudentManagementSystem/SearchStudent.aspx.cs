using StudentClass;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StudentManagementSystem
{
    public partial class SearchStudent : System.Web.UI.Page
    {
        private Student _studentService;
        private Student _getValues;
        private static int _studentEnrollmentNumber;

        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
            _studentService = new Student(connectionString);
             
             _studentEnrollmentNumber = Convert.ToInt32(txtStudentId.Text);
             if (_studentService.SearchStudent(_studentEnrollmentNumber))
             {
                 Response.Redirect(String.Format("UpdateStudent.aspx?RollNo={0}",_studentEnrollmentNumber));
             }

             else
                 Response.Redirect("HomePage.aspx");
            
        }
    }
}
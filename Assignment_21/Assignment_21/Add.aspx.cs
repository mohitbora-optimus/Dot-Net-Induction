using StudentClass;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment_21
{
    public partial class Add : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Student newStudent = new Student();
            string connectionString = ConfigurationManager.ConnectionStrings["connectionstring"].ConnectionString;
            newStudent.AddStudent(connectionString, txtName.Text, Convert.ToInt32(txtEnrollmentNumber.Text), Convert.ToInt32(txtMarks.Text), Convert.ToInt32(txtAge.Text), txtGender.Text);
            Response.Redirect("Home.aspx");
        }
    }
}
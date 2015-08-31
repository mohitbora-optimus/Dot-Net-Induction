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
    public partial class AddStudent : System.Web.UI.Page
    {
        private Student _student;
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }



        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
            _student = new Student(connectionString);
          
            _student.AddStudent(txtName.Text, Convert.ToInt32(txtEnrollNumber.Text), Convert.ToInt32(txtstreamId.Text), Convert.ToInt32(txtMarks.Text), Convert.ToInt32(txtStateId.Text), txtState.Text, txtStream.Text);
            Response.Redirect("HomePage.aspx");
        }

      
    }
}
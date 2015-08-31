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
    public partial class UpdateStudent : System.Web.UI.Page
    {
        private Student _studentService;

        protected void Page_Load(object sender, EventArgs e)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
            _studentService = new Student(connectionString);
            if (!IsPostBack)
            {

                int enrollmentNumber = Convert.ToInt32(Request.Params["RollNo"]);
                _studentService.GetDetails(enrollmentNumber);


                txtName.Text = _studentService.Name;
                txtEnrollNumber.Text = _studentService.EnrollmentNumber.ToString();
                txtMarks.Text = _studentService.Marks.ToString();

                List<string> states =_studentService.GetAllStateName();

                ddlState.DataSource = states;
                ddlState.DataBind();

                List<int> stateId = _studentService.GetAllStateId();
                ddlStateId.DataSource = stateId;
                ddlStateId.DataBind();


                List<string> streams = _studentService.GetAllStreamName();
                ddlStream.DataSource = streams;
                ddlStream.DataBind();

                List<int> streamsId = _studentService.GetAllStreamId();
                ddlStreamId.DataSource = streamsId;
                ddlStreamId.DataBind();
                
            }
            else
            {
                _studentService.AddStudent(txtName.Text, Convert.ToInt32(txtEnrollNumber.Text), Convert.ToInt32(ddlStreamId.Text), Convert.ToInt32(txtMarks.Text), Convert.ToInt32(ddlStateId.Text), ddlState.Text, ddlStream.Text);
            }
        }


        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
            _studentService = new Student(connectionString);
            _studentService.UpdateStudent(txtName.Text, Convert.ToInt32(txtEnrollNumber.Text), Convert.ToInt32(ddlStreamId.Text), Convert.ToInt32(txtMarks.Text), Convert.ToInt32(ddlStateId.Text), ddlState.Text, ddlStream.Text);
            Response.Redirect("HomePage.aspx");
        }

        

   

    }
}
using StudentClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StudentManagementSystem
{
    public partial class HomePage : System.Web.UI.Page
    {
        private Student _studentService;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {

            Response.Redirect("SearchStudent.aspx");
        }

        protected void btnAddStudent_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddStudent.aspx");
        }

        protected void btnAllStudent_Click(object sender, EventArgs e)
        {
            Response.Redirect("SelectStream.aspx");
        }
    }
}
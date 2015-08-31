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
    public partial class AllStudent1 : System.Web.UI.Page
    {
        private Student _studentService; 

        protected void Page_Load(object sender, EventArgs e)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
            _studentService = new Student(connectionString);

            gvAllStudent.DataSource = _studentService.ShowAll(Convert.ToInt32(Request.Params["streamId"]));
            gvAllStudent.DataBind();
        }
    }
}
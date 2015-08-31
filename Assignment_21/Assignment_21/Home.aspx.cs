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
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            Response.Redirect("Add.aspx");
        }

        protected void btnUpload_Click(object sender, EventArgs e)
        {
            Response.Redirect("Upload.aspx");
        }

        protected void btnWriteToCsv_Click(object sender, EventArgs e)
        {
            Student studentObject = new Student();
            string connectionString = ConfigurationManager.ConnectionStrings["connectionstring"].ConnectionString;
            studentObject.writeToCsv(connectionString);
        }

        protected void btnUpload_Click1(object sender, EventArgs e)
        {
            Response.Redirect("Upload.aspx");
        }
    }
}
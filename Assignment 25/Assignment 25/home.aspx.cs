using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WriterClass;

namespace Assignment_25
{
    public partial class home : System.Web.UI.Page
    {
        private string fileName = System.Configuration.ConfigurationManager.AppSettings["path"].ToString();
        WriteOnXml _writer;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            Response.Redirect("newStudent.aspx");
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            Response.Redirect("moreStudent.aspx");
        }

        protected void btnShowMCA_Click(object sender, EventArgs e)
        {
            Response.Redirect("MCAStudents.aspx");
        }

        protected void btnShowGradd_Click(object sender, EventArgs e)
        {
            Response.Redirect("ShowDGradeStudent.aspx");
        }
    }
}
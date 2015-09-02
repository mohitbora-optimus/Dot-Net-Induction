using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WriterClass;

namespace Assignment_25
{
    public partial class moreStudent : System.Web.UI.Page
    {
        private string fileName = System.Configuration.ConfigurationManager.AppSettings["path"].ToString();
        WriteOnXml _writer;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            _writer = new WriteOnXml(fileName);
            _writer.AddMoreStudent(txtName.Text, txtBranch.Text, txtGrade.Text);
            Response.Redirect("home.aspx");
        }
    }
}
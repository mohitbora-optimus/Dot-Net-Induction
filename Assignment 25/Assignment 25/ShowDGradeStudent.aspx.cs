using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WriterClass;

namespace Assignment_25
{
    public partial class ShowDGradeStudent : System.Web.UI.Page
    {

        WriteOnXml _writer;
        private string fileName = System.Configuration.ConfigurationManager.AppSettings["path"].ToString();

        protected void Page_Load(object sender, EventArgs e)
        {
            _writer = new WriteOnXml(fileName);
            gvDGrade.DataSource = _writer.ShowDGradeStudent();
            gvDGrade.DataBind();

        }
    }
}
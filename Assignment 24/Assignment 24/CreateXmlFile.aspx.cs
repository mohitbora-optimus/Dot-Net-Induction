using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WritingOnXml;

namespace Assignment_24
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        private Write _write;
        public string fileName = System.Configuration.ConfigurationManager.AppSettings["path"].ToString();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            _write = new Write(fileName);
            _write.CreateFile();
        }

        protected void btnViewXml_Click(object sender, EventArgs e)
        {
            Response.Redirect("Link.aspx");
        }
    }
}
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using WritingOnXml;

namespace Assignment_24
{
    public partial class Link : System.Web.UI.Page
    {
        public string fileName = System.Configuration.ConfigurationManager.AppSettings["path"].ToString();
        private Write _write;

        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            _write = new Write(fileName);
            _write.Add();
        }

        protected void btnFirstChid_Click(object sender, EventArgs e)
        {
            _write = new Write(fileName);
            txtFirstChild.Text = _write.ShowFirstChild();
        }

        protected void btnViewXml_Click(object sender, EventArgs e)
        {
            _write = new Write(fileName);
           
            System.Diagnostics.Process.Start("chrome.exe", fileName);
        }

        protected void btnInsertBefore_Click(object sender, EventArgs e)
        {
            _write = new Write(fileName);
            _write.InsertBefore();
        }

        protected void btnRemoveNode_Click(object sender, EventArgs e)
        {
            _write = new Write(fileName);
            _write.Remove();
        }

        protected void btnChildNode_Click(object sender, EventArgs e)
        {
            Response.Redirect("Childs.aspx");
        }

        protected void btnTotalNode_Click(object sender, EventArgs e)
        {
            _write = new Write(fileName);

            txtFirstChild.Text = _write.Count().ToString();
        }

        protected void btnReplaceChild_Click(object sender, EventArgs e)
        {
            _write = new Write(fileName);
            _write.Replace();
        }
    }
}
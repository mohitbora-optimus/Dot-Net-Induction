using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WritingOnXml;

namespace Assignment_24
{
    public partial class Childs : System.Web.UI.Page
    {
        private Write _write;
        public string fileName = System.Configuration.ConfigurationManager.AppSettings["path"].ToString();

        protected void Page_Load(object sender, EventArgs e)
        {
            _write = new Write(fileName);
            List<string> childs = _write.PrintChild();

            string temp="";

            foreach (string name in childs)
                temp = temp + name + "\n";
            txtChilds.Text = temp;
        }
    }
}
using StudentClass;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment_21
{
    public partial class Upload : System.Web.UI.Page
    {
        private Student _student;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (frmUploaFile.HasFile)
            {

                try
                {
                    string fileName = Path.GetFileName(frmUploaFile.FileName);
                    frmUploaFile.SaveAs(Server.MapPath("Uploads") + "\\" + fileName);
                    lblStatus.Text = "Upload Status : File uploaded !";
                    _student = new Student(Server.MapPath("Uploads") + "\\" + fileName);

                }
                catch (Exception ex)
                {
                    lblStatus.Text = "Upload Status : the file couldn't be uploaded . the following error occoured: " + ex.Message;
                }
            }
            else
            {
                lblStatus.Text = "Upload status: no file selected !!!!!1";
            }


        }
    }
}
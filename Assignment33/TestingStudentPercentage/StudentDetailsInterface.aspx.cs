using System;

namespace TestingStudentPercentage
{
    public partial class StudentDetailsInterface : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            CheckPercentage checkPercentage = new CheckPercentage();
            lblStatus.Text = checkPercentage.CheckPercentageValidity(txtPercentage.Text);
        }
    }
}
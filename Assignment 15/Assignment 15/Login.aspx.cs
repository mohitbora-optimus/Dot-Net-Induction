using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
namespace Assignment_15
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
                lblError.Text += "Error : user name or password is not entered ";
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPassword.Text == "")
                {
                    throw new PasswordNotEnteredException();
                }
            }
            catch (PasswordNotEnteredException)
            {
                Response.Redirect("Login.aspx");
            }

            try
            {
                if (txtUserName.Text =="")
                    throw new UserNameNotEnteredException();
            }
            catch (UserNameNotEnteredException)
            {
                
                Response.Redirect("Login.aspx");
            }
            Session["UserName"] = txtUserName.Text;
            Response.Redirect("Welcome.aspx");
        }
    }
}
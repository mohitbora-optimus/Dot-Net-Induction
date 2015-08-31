using StudentClass;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StudentManagementSystem
{
    public partial class AllStudent : System.Web.UI.Page
    {
        private Student _studentService;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var connectionString = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
                _studentService = new Student(connectionString);

                List<int> streamsId = _studentService.GetAllStreamId();
                ddlSelectStream.DataSource = streamsId;
                ddlSelectStream.DataBind();
            }
        }

        
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Response.Redirect(string.Format("AllStudent.aspx?streamId={0}", Convert.ToInt32((ddlSelectStream.SelectedItem.Value))));
        }
    }
}
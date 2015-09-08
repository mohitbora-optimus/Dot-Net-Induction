using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using View.Presentor;

namespace View.View
{
    public partial class InputUserDetails : System.Web.UI.Page, ICircle
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            CirclePresenter presenter = new CirclePresenter(this);
            presenter.CalculateArea();
        }
        public string Radius
        {
            get
            {
                return txtRadius.Text;
            }
            set
            {
                txtRadius.Text = value;
            }
        }

        public string Result
        {
            get
            {
                return txtResult.Text;
            }
            set
            {
                txtResult.Text = value;
            }
        }
    }
}
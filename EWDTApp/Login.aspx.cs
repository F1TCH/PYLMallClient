using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EWDTApp
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string i_username = tbxUsername.Text;
            string i_password = tbxPassword.Text;

            if (i_username.Equals("Admin"))
            {
                Session["username"] = "Admin";
                Response.Redirect("Home.aspx");
            }
        }

        protected void btnSignUp_Click(object sender, EventArgs e)
        {

        }
    }
}
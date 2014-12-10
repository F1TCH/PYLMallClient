using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EWDTApp
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if profile doesnt have any data, we can redirect to createprofile. make sure they dont come to this page
        }

        protected void btnCreateProfile_Click(object sender, EventArgs e)
        {
            Response.Redirect("CreateProfile.aspx");
        }

        protected void btnUpdateProfile_Click(object sender, EventArgs e)
        {
            Session["NRIC"] = lblNRIC.Text;
            Response.Redirect("UpdateProfilePage.aspx" + Session["NRIC"]);
        }

        protected void btnDeleteProfile_Click(object sender, EventArgs e)
        {
            Session["NRIC"] = lblNRIC.Text;
            Response.Redirect("DeleteProfilePage.aspx" + Session["NRIC"]);
        }
    }
}
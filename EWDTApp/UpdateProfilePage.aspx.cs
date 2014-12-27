using EWDTApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EWDTApp
{
    public partial class WebForm6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("ProfilePage.aspx");
        }

        protected void btnUpdateProfile_Click(object sender, EventArgs e)
        {
            string tele = tbxTeleNum.Text;
            string hp = tbxHandPhoneNum.Text;

            UserClass u1 = new UserClass();
            u1.HandphoneNo = Convert.ToInt32(hp);
            u1.TelephoneNo = Convert.ToInt32(tele);

            if (RentDBManager.UpdateProfile(u1) == 1)
            {
                Response.Redirect("ProfilePage.aspx");
            }
            else
            {
                lblStatus.Text = "Update Failed";
            }
        }

    }
}
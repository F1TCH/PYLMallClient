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
    public partial class WebForm5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("ProfilePage.aspx");
        }

        protected void btnCreateProfile_Click(object sender, EventArgs e)
        {
            string nric = tbxNRIC.Text;
            string tele = tbxTeleNum.Text;
            string gender = ddlGender.Text;
            string hp = tbxHandPhoneNum.Text;

            UserClass u = new UserClass();

            u.NRIC = nric;
            u.TelephoneNo = Convert.ToInt32(tele);
            u.HandphoneNo = Convert.ToInt32(hp);
            u.Gender = gender;

            if (RentDBManager.RegisterProfile(u) == 1)
            {
                Response.Redirect("ProfilePage.aspx");
            }
            else
            {
                lblStatus.Text = "Create Fail";
            }
        }
    }
}
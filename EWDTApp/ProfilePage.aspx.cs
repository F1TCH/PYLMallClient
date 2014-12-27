
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
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //string username = (string)Session["username"].ToString();
            //UserClass us = RentDBManager.GetProfile(username);

            //lblUsername.Text = username;
            //lblNRIC.Text = us.NRIC;
            //lblEmail.Text = RentDBManager.GetEmail(username);
            //lblTeleNum.Text = us.TelephoneNo.ToString();
            //lblHandPhoneNum.Text = us.HandphoneNo.ToString();
            //lblGender.Text = us.Gender;

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

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            string username = (string)Session["username"].ToString();
            RentDBManager.DeleteAccount(username);
            Response.Redirect("Login.aspx");
        }

        protected void btnChangeEmail_Click(object sender, EventArgs e)
        {
            Response.Redirect("ChangeEmailAddress.aspx");
        }

        protected void btnChangePassword_Click(object sender, EventArgs e)
        {
            Response.Redirect("ChangePassword.aspx");
        }
    }
}
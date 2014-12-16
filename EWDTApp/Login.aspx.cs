using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Http;
using System.Net.Http.Headers;
using EWDTWebServiceApp.Models;
using System.Net;
using System.Net.Mail;
using SendGrid;
using EWDTApp.Class;


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

            if (RentDBManager.Login(i_username, i_password) == true)
            {
                Session["username"] = i_username;
                Response.Redirect("Home.aspx");
            }
            else
            {
                lblStatus.Text = "Login Failed";
            }
        }

        protected void btnSignUp_Click(object sender, EventArgs e)
        {
            string username = tbxSignUpUser.Text;
            string password = tbxSignUpPass.Text;
            string email = tbxSignUpEmail.Text;
            UserAccount u = new UserAccount();
            u.username = username;
            u.password = password;
            u.email = email;

            if (RentDBManager.Register(u) == 1)
            {
                Response.Redirect("Home.aspx");
            }
            else
            {
                lblStatus.Text = "Registration Failed";
            }
        }
    }
}
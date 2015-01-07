using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Http;
using System.Net.Http.Headers;
using EWDTApp.Models;
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

            UserAccount ua = new UserAccount();
            ua.username = i_username;
            ua.password = i_password;

            HttpClient client = new HttpClient();

            client.BaseAddress = new Uri("http://localhost:52455/");
            // Add an Accept header for JSON format. 
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            string command = string.Format("http://localhost:52455/api/userAccount/username/"+i_username+"/password/"+i_password);
            HttpResponseMessage response = client.GetAsync(command).Result;
            

            if (response.IsSuccessStatusCode)
            {
                Session["username"] = i_username;
                Response.Redirect("Home.aspx");
            }

            else
            {
                lblStatus.Text = "Could not retrieve music. Error code: " + response.StatusCode + " reason: Reyner " + response.ReasonPhrase.ToString();
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
                UserClass u1 = new UserClass();
                u1.TelephoneNo = Convert.ToInt32(tbxSignUpTeleNo.Text);
                u1.HandphoneNo = Convert.ToInt32(tbxSignUpHpNo.Text);
                u1.NRIC = tbxNric.Text;
                u1.Gender = ddlGender.Text;
                u1.DoB = tbxDOB.Text;
                u1.SQ1 = DropDownList1.Text;
                u1.SQAns1 = tbxSQAnswer1.Text;
                u1.SQ2 = DropDownList2.Text;
                u1.SQAns2 = tbxSQAnswer2.Text;
                u1.Username = username;

                if (RentDBManager.RegisterProfile(u1) == 1)
                {
                    Response.Redirect("Home.aspx");
                }
            }
            else
            {
                lblStatus.Text = "Registration Failed";
            }
        }
    }
}
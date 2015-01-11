using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Http;
using System.Net.Http.Headers;
using EWDTApp.Class;
using System.Net;
using System.Net.Mail;
using SendGrid;


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

            HttpClient client = new HttpClient();

            client.BaseAddress = new Uri("http://localhost:52455/");
            // Add an Accept header for JSON format. 
            client.DefaultRequestHeaders.Accept.Add(
                  new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.GetAsync("api/userAccount?userID=" + i_username).Result;

            if (response.IsSuccessStatusCode)
            {
                // Parse the response body. Blocking! 
                var result = response.Content.ReadAsAsync<UserAccount>().Result;


                if (result.password == i_password)
                {
                    Session["username"] = i_username;
                    Response.Redirect("Home.aspx");
                }
            }
            else
            {
                lblStatus.Text = "Could not retrieve User. Error code: " + response.StatusCode + " reason: Reyner/Tim " + response.ReasonPhrase.ToString();
            }
        }

        protected void btnSignUp_Click(object sender, EventArgs e)
        {
            string username = tbxSignUpUser.Text;
            string password = tbxSignUpPass.Text;
            string email = tbxSignUpEmail.Text;
            Session["email"] = email;
            HttpClient client = new HttpClient();

            client.BaseAddress = new Uri("http://localhost:52455/");
            // Add an Accept header for JSON format. 
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            var u = new UserAccount() { username = username, password = tbxSignUpPass.Text, email = email };

            HttpResponseMessage response = client.PostAsJsonAsync("api/userAccount", u).Result;
            if (response.IsSuccessStatusCode)
            {
                //Uri gizmoUri = response.Headers.Location;
                lblStatus.Text = "Account created.";
                HttpClient client1 = new HttpClient();

                client1.BaseAddress = new Uri("http://localhost:52455/");
                // Add an Accept header for JSON format. 
                client1.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));

                var u1 = new UserClass() { Username = username, NRIC = tbxNric.Text, TelephoneNo = Convert.ToInt32(tbxSignUpTeleNo.Text), HandphoneNo = Convert.ToInt32(tbxSignUpHpNo.Text), Gender = ddlGender.Text, DoB = tbxDOB.Text, SQ1 = DropDownList1.Text, SQ2 = DropDownList2.Text, SQAns1 = tbxSQAnswer1.Text, SQAns2 = tbxSQAnswer2.Text };

                HttpResponseMessage response1 = client.PostAsJsonAsync("api/userProfile", u1).Result;
                if (response1.IsSuccessStatusCode)
                {
                    //Uri gizmoUri = response.Headers.Location;
                    lblStatus.Text = "Account created.";
                    Response.Redirect("Login.aspx");
                }
                else
                {
                    lblStatus.Text = "Could not create account. Error code:" + response.StatusCode + ", reason:" + response.ReasonPhrase.ToString() + "<br/>";
                }
            }
            else
            {
                lblStatus.Text = "Could not create account. Error code:" + response.StatusCode + ", reason:" + response.ReasonPhrase.ToString() + "<br/>";
            }
        }
    }
}
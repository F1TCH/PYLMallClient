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

            HttpClient client = new HttpClient();

            client.BaseAddress = new Uri("http://localhost:" + Session["portNumber"] + "/");
            // Add an Accept header for JSON format. 
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.GetAsync("api/UserClass/" + tbxUsername.Text).Result;
            if (response.IsSuccessStatusCode)
            {
                // Parse the response body. Blocking! 
                var m = response.Content.ReadAsAsync<UserClass>().Result;
                // password for login
            }
            else
            {
                Response.Write("Could not retrieve music. Error code:" + response.StatusCode + "reason:" + response.ReasonPhrase.ToString());
            }
            
        }

        protected void btnSignUp_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();

            client.BaseAddress = new Uri("http://localhost:" + Session["portNumber"] + "/");
            // Add an Accept header for JSON format. 
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            var m = new UserClass() { Username = tbxUsername.Text, Password = tbxPassword.Text, Email = tbxSignUpEmail.Text, TelephoneNo = Convert.ToInt32(tbxSignUpTeleNo.Text), HandphoneNo = Convert.ToInt32(tbxSignUpHpNo.Text), NRIC = tbxNric.Text, Gender = ddlGender.Text, Address = tbxAddress.Text, DoB = tbxDOB.Text, SQ1 = DropDownList1.Text, SQAns1 = tbxSQAnswer1.Text, SQ2 = DropDownList2.Text, SQAns2 = tbxSQAnswer2.Text};

            HttpResponseMessage response = client.PostAsJsonAsync("api/UserClass", m).Result;
            if (response.IsSuccessStatusCode)
            {
                //Uri gizmoUri = response.Headers.Location;
                lblStatus.Text = "Music created.";
            }
            else
            {
                lblStatus.Text = "Could not create music. Error code:" + response.StatusCode + ", reason:" + response.ReasonPhrase.ToString() + "<br/>";
            }
        }
    }
}
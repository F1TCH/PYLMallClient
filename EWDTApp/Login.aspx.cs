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

            HttpResponseMessage response = client.GetAsync("api/user/" + tbxUsername.Text).Result;
            if (response.IsSuccessStatusCode)
            {
                // Parse the response body. Blocking! 
                var m = response.Content.ReadAsAsync<UserAccount>().Result;
                Session["username"] = tbxUsername.Text;
                Response.Redirect("Home.aspx");
                // password for login
            }
            else
            {
                Response.Write("Could not retrieve account. Error code:" + response.StatusCode + "reason:" + response.ReasonPhrase.ToString());
            }

        }

        protected void btnSignUp_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();

            client.BaseAddress = new Uri("http://localhost:" + Session["portNumber"] + "/");
            // Add an Accept header for JSON format. 
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            var m = new UserAccount() { username = tbxSignUpUser.Text, password = tbxSignUpPass.Text, email = tbxSignUpEmail.Text };

            HttpResponseMessage response = client.PostAsJsonAsync("api/user", m).Result;
            if (response.IsSuccessStatusCode)
            {
                //Uri gizmoUri = response.Headers.Location;
                Response.Redirect("Home.aspx");
            }
            else
            {
                lblStatus.Text = "Could not create music. Error code:" + response.StatusCode + ", reason:" + response.ReasonPhrase.ToString() + "<br/>";
            }
        }
    }
}
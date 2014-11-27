using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Http;
using System.Net.Http.Headers;

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
            HttpClient client = new HttpClient();

            client.BaseAddress = new Uri("http://localhost:" + Session["portNumber"] + "/");
            // Add an Accept header for JSON format. 
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            var m = new UserClass() { Username = tbxUsername.Text, Password = tbxPassword.Text, Email = tbxSignUpEmail.Text, TelephoneNumber = Convert.ToInt32(tbxSignUpTeleNo.Text), HandPhoneNumber = Convert.ToInt32(tbxSignUpHpNo.Text), NRIC = tbxNric.Text, Gender = ddlGender.Text, Address = tbxAddress.Text, DoB = tbxDOB.Text, SecretQuestion1 = DropDownList1.Text, SecretAnswer1 = tbxSQAnswer1.Text, SecretQuestion2 = DropDownList2.Text, SecretAnswer2 = tbxSQAnswer2};

            HttpResponseMessage response = client.PostAsJsonAsync("api/User", m).Result;
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
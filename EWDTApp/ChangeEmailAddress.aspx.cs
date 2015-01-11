using EWDTApp.Class;
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
    public partial class WebForm7 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //HttpClient client = new HttpClient();

            //client.BaseAddress = new Uri("http://localhost:" + Session["portNumber"] + "/");
            //// Add an Accept header for JSON format. 
            //client.DefaultRequestHeaders.Accept.Add(
            //    new MediaTypeWithQualityHeaderValue("application/json"));

            //HttpResponseMessage response = client.GetAsync("api/user/" + Session["username"].ToString()).Result;
            //if (response.IsSuccessStatusCode)
            //{
            //    // Parse the response body. Blocking! 
            //    var m = response.Content.ReadAsAsync<UserAccount>().Result;
            //    lblEmail.Text = m.email;
            //    Response.Redirect("Home.aspx");
            //}
            //else
            //{
            //    Response.Write("Could not retrieve account. Error code:" + response.StatusCode + "reason:" + response.ReasonPhrase.ToString());
            //}
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("ProfilePage.aspx");
        }

        protected void btnChange_Click(object sender, EventArgs e)
        {
            string email = tbxEmail.Text;
            string username = Session["username"].ToString();
            string password = tbxPassword.Text;
            
            HttpClient client = new HttpClient();

            client.BaseAddress = new Uri("http://localhost:52455/");
            // Add an Accept header for JSON format. 
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            var user = new UserAccount() { username = username, email = email, password = password};

            HttpResponseMessage response = client.PutAsJsonAsync("api/userAccount/" + username, user).Result;

            if (response.IsSuccessStatusCode)
            {
                //Uri gizmoUri = response.Headers.Location;
                lblStatus.Text = "Emile updated.";
                Response.Redirect("ProfilePage.aspx");
            }
            else
            {
                lblStatus.Text = "Could not update profile. Error code:" + response.StatusCode + ", reason:" + response.ReasonPhrase.ToString() + "<br/>";
            }
        }
    }
}
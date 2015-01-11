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
            int tele = Convert.ToInt32(tbxTeleNum.Text);
            int hp = Convert.ToInt32(tbxHandPhoneNum.Text);
            string username = Session["username"].ToString();

            HttpClient client = new HttpClient();

            client.BaseAddress = new Uri("http://localhost:52455/");
            // Add an Accept header for JSON format. 
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            var user = new UserClass() { Username = username, TelephoneNo = tele, HandphoneNo = hp };

            HttpResponseMessage response = client.PutAsJsonAsync("api/userProfile/" + username, user).Result;

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
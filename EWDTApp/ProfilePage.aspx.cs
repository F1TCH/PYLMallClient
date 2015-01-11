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
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string i_username = Session["username"].ToString();
            HttpClient client = new HttpClient();

            client.BaseAddress = new Uri("http://localhost:52455/");
            // Add an Accept header for JSON format. 
            client.DefaultRequestHeaders.Accept.Add(
                  new MediaTypeWithQualityHeaderValue("application/json"));

            
            HttpResponseMessage response = client.GetAsync("api/userProfile?userID=" + i_username).Result;

            if (response.IsSuccessStatusCode)
            {
                // Parse the response body. Blocking! 
                
                var result = response.Content.ReadAsAsync<UserClass>().Result;
                
                
                lblNRIC.Text = result.NRIC;
                lblTeleNum.Text = result.TelephoneNo.ToString();
                lblHandPhoneNum.Text = result.HandphoneNo.ToString();
                lblGender.Text = result.Gender;
            }
                HttpResponseMessage response1 = client.GetAsync("api/userAccount?userID=" + i_username).Result;
                if (response1.IsSuccessStatusCode)
                {
                    var result1 = response1.Content.ReadAsAsync<UserAccount>().Result;
                    lblEmail.Text = result1.email;
                }
            
            else
            {
                lblStatus.Text = "Could not retrieve User. Error code: " + response.StatusCode + " reason: Reyner/Tim " + response.ReasonPhrase.ToString();
            }
        }

        protected void btnCreateProfile_Click(object sender, EventArgs e)
        {
            Response.Redirect("CreateProfile.aspx");
        }

        protected void btnUpdateProfile_Click(object sender, EventArgs e)
        {
            Session["NRIC"] = lblNRIC.Text;
            Response.Redirect("UpdateProfilePage.aspx");
        }

        protected void btnDeleteProfile_Click(object sender, EventArgs e)
        {
            Session["NRIC"] = lblNRIC.Text;
            Response.Redirect("DeleteProfilePage.aspx");
        }


        //useraccount
        protected void btnDelete_Click(object sender, EventArgs e)
        {
            string username = (string)Session["username"].ToString();
            HttpClient client = new HttpClient();

            client.BaseAddress = new Uri("http://localhost:52455/");
            // Add an Accept header for JSON format. 
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = client.DeleteAsync("api/userAccount/" + username).Result;

            if (response.IsSuccessStatusCode)
            {
                //Uri gizmoUri = response.Headers.Location;
                lblStatus.Text = "Account deleted.";
            }
            else
            {
                lblStatus.Text = "Could not delete music. Error code:" + response.StatusCode + ", reason:" + response.ReasonPhrase.ToString();
            }
            Response.Redirect("Login.aspx");
        }

        protected void btnChangeEmail_Click(object sender, EventArgs e)
        {
            Response.Redirect("ChangeEmailAddress.aspx");
        }
    }
}
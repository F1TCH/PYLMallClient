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
            //if profile doesnt have any data, we can redirect to createprofile. make sure they dont come to this page
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
            HttpClient client = new HttpClient();

            client.BaseAddress = new Uri("http://localhost:" + Session["portNumber"] + "/");
            // Add an Accept header for JSON format. 
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.DeleteAsync("api/useraccount/" + Session["username"].ToString()).Result;
            if (response.IsSuccessStatusCode)
            {
                //Uri gizmoUri = response.Headers.Location;
                Session.Abandon();
                Response.Redirect("Home.aspx");
            }
            else
            {
                lblStatus.Text = "Could not delete music. Error code:" + response.StatusCode + ", reason:" + response.ReasonPhrase.ToString();
            }
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
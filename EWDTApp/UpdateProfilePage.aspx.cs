using EWDTWebServiceApp.Models;
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
            HttpClient client = new HttpClient();

            client.BaseAddress = new Uri("http://localhost:" + Session["portNumber"] + "/");
            // Add an Accept header for JSON format. 
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            var userprofile = new UserClass() { NRIC = tbxNRIC.Text, Address = tbxAddress.Text, Email = tbxEmail.Text, Gender = ddlGender.Text, HandphoneNo = Convert.ToInt32(tbxHandPhoneNum.Text), TelephoneNo = Convert.ToInt32(tbxTeleNum.Text) };

            HttpResponseMessage response = client.PutAsJsonAsync("api/userclass/" + tbxNRIC.Text, userprofile).Result;

            if (response.IsSuccessStatusCode)
            {
                //Uri gizmoUri = response.Headers.Location;
                Response.Redirect("ViewBids.aspx");
            }
            else
            {
            }
        }

    }
}
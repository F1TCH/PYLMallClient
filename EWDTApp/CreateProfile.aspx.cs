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
    public partial class WebForm5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("ProfilePage.aspx");
        }

        protected void btnCreateProfile_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();

            client.BaseAddress = new Uri("http://localhost:" + Session["portNumber"] + "/");
            // Add an Accept header for JSON format. 
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            var m = new UserClass() { NRIC = tbxNRIC.Text, Email = tbxEmail.Text, TelephoneNo = Convert.ToInt32(tbxTeleNum.Text), HandphoneNo = Convert.ToInt32(tbxHandPhoneNum.Text), Gender = ddlGender.Text, Address = tbxAddress.Text };

            HttpResponseMessage response = client.PostAsJsonAsync("api/UserProfile", m).Result;
            if (response.IsSuccessStatusCode)
            {
                
            }
            else
            {
                
            }
        }
    }
}
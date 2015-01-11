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
    public partial class WebForm8 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UserAccount u1 = new UserAccount();
            u1.username = Session["username"].ToString();
            Session["currentPwd"] = RentDBManager.GetPassword(u1);
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {

        }

        protected void btnChange_Click(object sender, EventArgs e)
        {
            string password = tbxRetypePw.Text;
            string username = Session["username"].ToString();

            //UserAccount u1 = new UserAccount();
            //u1.password = password;
            //u1.username = username;
            //if (tbxCurrentPw.Text == (string)Session["currentPwd"].ToString())
            //{
            //    if (RentDBManager.UpdatePassword(u1) == 1)
            //    {
            //        Response.Redirect(Request.RawUrl);
            //    }
            //    else
            //    {
            //        Response.Redirect("Home.aspx");
            //    }
            //}


            HttpClient client = new HttpClient();

            client.BaseAddress = new Uri("http://localhost:52455/");
            // Add an Accept header for JSON format. 
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            var user = new UserAccount() { username = username, password = password };

            HttpResponseMessage response = client.PutAsJsonAsync("api/userAccount/" + username, user).Result;

            if (response.IsSuccessStatusCode)
            {
                //Uri gizmoUri = response.Headers.Location;
                lblStatus.Text = "Password updated.";
                Response.Redirect("ProfilePage.aspx");
            }
            else
            {
                lblStatus.Text = "Could not update profile. Error code:" + response.StatusCode + ", reason:" + response.ReasonPhrase.ToString() + "<br/>";
            }

        }
    }
}
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
    public partial class WebForm11 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            lblDate.Text = dateTime.ToString("dd/MM/yy");
            lblTime.Text = dateTime.ToString("hh:MM:ss");
        }

        protected void btnUpdateBid_Click(object sender, EventArgs e)
        {
            string BiddingAmt = tbxBiddingAmount.Text;
            string Time = lblTime.Text;
            string Date = lblDate.Text;
            string Username = Session["username"].ToString();

            HttpClient client = new HttpClient();

            client.BaseAddress = new Uri("http://localhost:52455/");
            // Add an Accept header for JSON format. 
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            var u = new BidClass() { BiddingAmt = BiddingAmt, Time = Time, Date = Date, Username = Username };

            HttpResponseMessage response = client.PutAsJsonAsync("api/bid/"+ Username, u).Result;
            if (response.IsSuccessStatusCode)
            {
                lblStatus.Text = "Success"; 
            }
            else
            {
                lblStatus.Text = "Could not create account. Error code:" + response.StatusCode + ", reason:" + response.ReasonPhrase.ToString() + "<br/>";
            }
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewBid.aspx");
        }
    }
}
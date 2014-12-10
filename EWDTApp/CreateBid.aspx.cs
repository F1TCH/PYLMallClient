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
    public partial class WebForm10 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            lblDate.Text = dateTime.ToString("dd/MM/yy");
            lblTime.Text = dateTime.ToString("HH:MM:ss");
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {

        }

        protected void btnCreateBid_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();

            client.BaseAddress = new Uri("http://localhost:" + Session["portNumber"] + "/");
            // Add an Accept header for JSON format. 
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            var m = new BidClass() { BiddingAmt = Convert.ToDouble(tbxBiddingAmount.Text), Date = lblDate.Text, Time = lblTime.Text};

            HttpResponseMessage response = client.PostAsJsonAsync("api/biddingclass", m).Result;
            if (response.IsSuccessStatusCode)
            {
                //Uri gizmoUri = response.Headers.Location;
                Response.Redirect("ViewBid.aspx");
            }
            else
            {
                Response.Redirect("ViewBid.aspx");
            }
        }
    }
}
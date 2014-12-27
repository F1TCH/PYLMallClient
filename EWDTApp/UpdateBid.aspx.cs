using EWDTApp.Models;
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
            //HttpClient client = new HttpClient();

            //client.BaseAddress = new Uri("http://localhost:" + Session["portNumber"] + "/");
            //// Add an Accept header for JSON format. 
            //client.DefaultRequestHeaders.Accept.Add(
            //    new MediaTypeWithQualityHeaderValue("application/json"));

            //var bidclass = new BidClass() { BiddingAmt = Convert.ToDouble(tbxBiddingAmount.Text), Date = lblDate.Text, Time = lblTime.Text };

            //HttpResponseMessage response = client.PutAsJsonAsync("api/biddingclass/" + lblPreviousBid.Text, bidclass).Result;

            //if (response.IsSuccessStatusCode)
            //{
            //    //Uri gizmoUri = response.Headers.Location;
            //    Response.Redirect("ViewBids.aspx");
            //}
            //else
            //{
            //    BidClass editBid = new BidClass();
            //    editBid.BiddingAmt = Convert.ToDouble(tbxBiddingAmount.Text);
            //    editBid.Date = lblDate.Text;
            //    editBid.Time = lblTime.Text;

            //    if (RentDBManager.UpdateBid(editBid) == 1)
            //    {
            //        Response.Redirect("ViewBid.aspx?");
            //    }
            //    Session["biddingAmount"] = Convert.ToDouble(tbxBiddingAmount.Text);
            //    Session["Date"] = lblDate.Text;
            //    Session["Time"] = lblTime.Text;
            //    Response.Redirect("ViewBids.aspx" + Session["biddingAmount"] + Session["Date"] + Session["Time"]);
            //}

            
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
          
        }
    }
}
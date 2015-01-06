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
            BidClass c = new BidClass();
            c.BiddingAmt = tbxBiddingAmount.Text;
            c.Time = lblTime.Text;
            c.Date = lblDate.Text;
            c.Username = Session["username"].ToString();

            if (RentDBManager.CreateBid(c) == 1)
            {
                Response.Redirect("ViewBid.aspx");
            }
            else
            {
                Response.Redirect("Home.aspx");
            }
        }
    }
}
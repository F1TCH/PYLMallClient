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
            BidClass r = new BidClass();
            r.BiddingAmt = tbxBiddingAmount.Text;
            r.Date = lblDate.Text;
            r.Time = lblTime.Text;
            r.Username = Session["username"].ToString();

            if (RentDBManager.UpdateBid(r) == 1)
            {
                Response.Redirect("ViewBid.aspx");
            }
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewBid.aspx");
        }
    }
}
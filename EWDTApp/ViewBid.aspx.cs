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
    public partial class WebForm12 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string username = Session["username"].ToString();
            BidClass c = RentDBManager.RetrieveBid(username);
            if (c != null)
            {
                lblBiddingAmount.Text = c.BiddingAmt;
                lblDate.Text = c.Date;
                lblTime.Text = c.Time;
            }
        }
        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            //BidClass editBid = new BidClass();
            //editBid.BiddingAmt = Convert.ToDouble(Label1.Text);
            //editBid.Date = Label2.Text;
            //editBid.Time = Label3.Text;

            //RentDBManager.UpdateBid(editBid);
            Response.Redirect("UpdateBid.aspx?");
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            string username = Session["username"].ToString();
            if (RentDBManager.DeleteBid(username) == 1)
            {
                Response.Redirect("ViewBid.aspx");
            }
            else
            {
                Response.Redirect("ViewBid.aspx");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("CreateBid.aspx");
        }

        protected void Rating_Changed(object sender, AjaxControlToolkit.RatingEventArgs e)
        {

        }

    }
}
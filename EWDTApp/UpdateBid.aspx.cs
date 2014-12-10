using EWDTWebServiceApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
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
            lblDate.Text = dateTime.ToString("DD/MM/YY");
            lblTime.Text = dateTime.ToString("HH:MM:SS");
        }

        protected void btnUpdateBid_Click(object sender, EventArgs e)
        {
            

            BidClass editBid = new BidClass();
            editBid.BiddingAmt = Convert.ToDouble(tbxBiddingAmount.Text);
            editBid.Date = lblDate.Text;
            editBid.Time = lblTime.Text;

            RentDBManager.UpdateBid(editBid);
            Response.Redirect("ViewBid.aspx?");
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
          
        }
    }
}
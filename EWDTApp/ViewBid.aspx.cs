using EWDTWebServiceApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EWDTApp
{
    public partial class WebForm12 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            //BidClass editBid = new BidClass();
            //editBid.BiddingAmt = Convert.ToDouble(Label1.Text);
            //editBid.Date = Label2.Text;
            //editBid.Time = Label3.Text;

            //RentDBManager.UpdateBid(editBid);
            //Response.Redirect("ViewBid.aspx?");
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            Response.Write("");
        }
    }
}
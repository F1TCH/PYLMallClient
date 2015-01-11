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
    public partial class WebForm12 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            string i_username = Session["username"].ToString();
            HttpClient client = new HttpClient();

            client.BaseAddress = new Uri("http://localhost:52455/");
            // Add an Accept header for JSON format. 
            client.DefaultRequestHeaders.Accept.Add(
                  new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.GetAsync("api/bid?userID=" + i_username).Result;

            if (response.IsSuccessStatusCode)
            {
                // Parse the response body. Blocking! 
                var result = response.Content.ReadAsAsync<BidClass>().Result;

                lblBiddingAmount.Text = result.BiddingAmt;
                DateTime date = Convert.ToDateTime(result.Date);
                lblDate.Text = date.ToString("dd/MM/yy");
                lblTime.Text = result.Time;
            }
            else
            {
                //lblStatus.Text = "Could not retrieve User. Error code: " + response.StatusCode + " reason: Reyner/Tim " + response.ReasonPhrase.ToString();
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
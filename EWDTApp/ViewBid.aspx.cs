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
            HttpClient client = new HttpClient();

            client.BaseAddress = new Uri("http://localhost:" + Session["portNumber"] + "/");
            // Add an Accept header for JSON format. 
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.GetAsync("api/bidding").Result;

            if (response.IsSuccessStatusCode)
            {
                // Parse the response body. Blocking! 
                var BidClass = response.Content.ReadAsAsync<IEnumerable<BidClass>>().Result;
                foreach (var m in BidClass)
                {
                    lblBA.Text = m.BiddingAmt.ToString();
                }
            }
            else
            {
                
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
            HttpClient client = new HttpClient();

            client.BaseAddress = new Uri("http://localhost:" + Session["portNumber"] + "/");
            // Add an Accept header for JSON format. 
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.DeleteAsync("api/bidclass/" + lblBA.Text).Result;
            if (response.IsSuccessStatusCode)
            {
                Response.Redirect("Home.aspx");
            }
            else
            {
                Response.Write("Could not delete music. Error code:" + response.StatusCode + ", reason:" + response.ReasonPhrase.ToString());
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("CreateBid.aspx");
        }
    }
}
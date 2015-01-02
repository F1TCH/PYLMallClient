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
    public partial class WebForm9 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            string username = Session["username"].ToString();
            if (RentDBManager.DeleteProfile(username) == 1)
            {
                Response.Redirect("ProfilePage.aspx");
            }
            else
            {

            }
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {            
            Response.Redirect("ProfilePage.aspx");
        }
    }
}
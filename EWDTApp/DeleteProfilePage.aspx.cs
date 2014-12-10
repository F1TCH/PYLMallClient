﻿using System;
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
            string nric = Session["NRIC"].ToString();

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:" + Session["portnumber"] + "/");
            //Add an Accept header for JSON format
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.DeleteAsync("api/UserProfile/" + nric).Result;

            if (response.IsSuccessStatusCode)
            {
                //parse the response body. Blocking!
                //lblStatus.Text = "Music Deleted";
            }
            else
            {
                //lblStatus.Text = "Could not delete music. Error Code:" + response.StatusCode + "reason:" + response.ReasonPhrase.ToString();
            }
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {            
            Response.Redirect("ProfilePage.aspx");
        }
    }
}
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
    public partial class WebForm8 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            
        }

        protected void btnChange_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();

            client.BaseAddress = new Uri("http://localhost:" + "/");

            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            var password = new UserAccount() { password = tbxPassword.Text };

            HttpResponseMessage response = client.PutAsJsonAsync("api/user/" + tbxPassword.Text, password).Result;

            if (response.IsSuccessStatusCode)
            {
                //lblEmail.Text
            }
        }
    }
}
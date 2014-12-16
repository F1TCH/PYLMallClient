using EWDTApp.Class;
using EWDTWebServiceApp.Models;
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
            UserAccount u1 = new UserAccount();
            u1.username = Session["username"].ToString();
            tbxPassword.Text = RentDBManager.GetPassword(u1);
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            
        }

        protected void btnChange_Click(object sender, EventArgs e)
        {
            string password = tbxPassword.Text;
        }
    }
}
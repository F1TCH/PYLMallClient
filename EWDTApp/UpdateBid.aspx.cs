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

        }

        protected void btnBack_Click(object sender, EventArgs e)
        {

        }
    }
}
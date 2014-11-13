using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EWDTApp
{
    public partial class EWDTMain : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] != null)
            {
                if ((string)Session["username"] != "Administrator")
                {
                    A1.Visible = false;
                    viewUnit.Visible = true;
                    viewCurrentBid.Visible = true;
                    profile.Visible = true;
                    logout.Visible = true;
                }
            }
        }
    }
}
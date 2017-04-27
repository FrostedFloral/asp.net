using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if (Session["LoggedIn"] != null && Session["LoggedIn"].ToString() == "1")
        {
            lblUser.Text = "Here logs " + Session["User"].ToString();
            navLogin.HRef = "Logout.aspx";
            navLogin.InnerText = "Logout";
        }
        else
        {
            navAdd.HRef = "Login.aspx";
        }
    }
}

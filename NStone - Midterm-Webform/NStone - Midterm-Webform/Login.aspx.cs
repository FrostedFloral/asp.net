using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;  // Library to connect to Access DB's
using System.Data;        // Library to bring in a dataset

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        lblFeedback.Text = "";
        //Search for account
        User login = new User();
        SqlDataReader dr = login.FindUser(txtUserName.Text, txtPassword.Text);

        //if username & password match db
        while (dr.Read())
        {
            //Give session key
            Session["LoggedIn"] = "1";
            Session["User"] = dr["UName"].ToString();
            lblFeedback.Text = "Welcome, " + Session["User"].ToString();
            Response.Redirect("default.aspx");
        }
        //if failed match
        if (lblFeedback.Text == "")
        {
            lblFeedback.Text = "Log in failed!";
        }
    }
}
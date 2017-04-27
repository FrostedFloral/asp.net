using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;


public partial class Gravesites : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnSearch_Click(object sender, EventArgs e)
    {
        Grave search = new Grave();

        DataSet ds = search.SearchGraves(txtCemetery.Text, txtFName.Text, txtLName.Text);

        gvGravestones.DataSource = ds;
        gvGravestones.DataMember = ds.Tables[0].TableName;
        gvGravestones.DataBind();
    }
}
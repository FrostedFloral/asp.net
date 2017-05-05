using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ContactMgr : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Person Add = new Person();

        Add.FName = txtFName.Text;
        Add.MName = txtMName.Text;
        Add.LName = txtLName.Text;
        Add.Street1 = txtStreet1.Text;
        Add.Street2 = txtStreet2.Text;
        Add.City = txtCity.Text;
        Add.State = ddlState.Text;
        Add.Zip = txtZip.Text;
        Add.Country = txtCountry.Text;
        Add.Phone = txtPhone.Text;
        Add.Email = txtEmail.Text;
    }
}
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

        Add.Title =  rblTitle.SelectedValue.ToString();
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
        Add.Birthday = calBirth.SelectedDate.Date.ToShortDateString();
        Add.Anniversary = calAnni.SelectedDate.Date.ToShortDateString();

        if (Add.Feedback.Contains("Error:"))
        {
            lblDisplay.Text = Add.Feedback;
        }
        else
        {
            lblDisplay.Text = Add.Title + " " + Add.FName + " " + Add.MName + " " + Add.LName + "<br />" +
                Add.Street1 + "<br />";
            if (Add.Street2 != "")
            {
                lblDisplay.Text += Add.Street2 + "<br />";
            }
            lblDisplay.Text +=Add.City + ", " + Add.State + " " + Add.Zip + "<br />"+ 
                Add.Country + "<br />" +
                "Phone: " + Add.Phone + "<br />" +
                "Email: " + Add.Email + "<br />" +
                "Birthday: " + Add.Birthday + "<br />" +
                "Anniversery: " + Add.Anniversary + "<br />";
        }
    }
}
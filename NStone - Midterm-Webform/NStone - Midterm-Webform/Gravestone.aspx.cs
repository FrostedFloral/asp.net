using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Gravestone : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //add cemetery locations
        ddlCemetery.Items.Add("On the moon");
        ddlCemetery.Items.Add("On the chair");
        ddlCemetery.Items.Add("In my soup");
        ddlCemetery.Items.Add("In my spagetti");
        ddlCemetery.Items.Add("On the grass");
        ddlCemetery.Items.Add("In my shoes");

        //add military branches
        ddlMilitary.Items.Add("N/A");
        ddlMilitary.Items.Add("Army");
        ddlMilitary.Items.Add("Navy");
        ddlMilitary.Items.Add("Air Force");
        ddlMilitary.Items.Add("Coast Guard");
        ddlMilitary.Items.Add("Marine Corps");

        //add stone conditions
        ddlStone.Items.Add("Stable");
        ddlStone.Items.Add("Ongoing deterioration");
        ddlStone.Items.Add("unstable deterioration");
        ddlStone.Items.Add("hazardous");

        //////////////////////////////////////////
        // EDIT UPDATE DELETE
        //////////////////////////////////////////

        //IDs for editing
        string strGraveID = "";
        int intGraveID = 0;

        //Does Per_ID Exist?
        if ((!IsPostBack) && Request.QueryString["Grave_ID"] != null)
        {
            //If so...Gather Person's ID and Fill Form
            strGraveID = Request.QueryString["Grave_ID"].ToString();
            //lblPerson_ID.Text = strPer_ID;

            intGraveID = Convert.ToInt32(strGraveID);

            //Fill the "temp" person's info based on ID
            Grave edit = new Grave();
            SqlDataReader dr = edit.FindGrave(intGraveID);

            while (dr.Read())
            {
                //title
                string strTitle = dr["Title"].ToString();
                if (strTitle == "Mr.") { rbtnMr.Checked = true; }
                else if (strTitle == "Ms.") { rbtnMs.Checked = true; }
                else if (strTitle == "Mrs.") { rbtnMrs.Checked = true; }
                else if (strTitle == "Miss.") { rbtnMiss.Checked = true; }
                else if (strTitle == "Dr.") { rbtnDr.Checked = true; }
                else if (strTitle == "Rev.") { rbtnRev.Checked = true; }
                //names
                txtFName.Text = dr["FName"].ToString();
                txtMName.Text = dr["MName"].ToString();
                txtLName.Text = dr["LName"].ToString();
                //dates
                string strBirth = dr["Dob"].ToString();
                DateTime dtBirth = Convert.ToDateTime(strBirth);
                txtDOBMonth.Text = dtBirth.Month.ToString();
                txtDOBDay.Text = dtBirth.Day.ToString();
                txtDOBYear.Text = dtBirth.Year.ToString();
                string strDeath = dr["Dod"].ToString();
                DateTime dtDeath = Convert.ToDateTime(strDeath);
                txtDODMonth.Text = dtDeath.Month.ToString();
                txtDODDay.Text = dtDeath.Day.ToString();
                txtDODYear.Text = dtDeath.Year.ToString();
                //drop downs
                ddlMilitary.Items.FindByText(dr["Military"].ToString()).Selected = true;
                ddlStone.Items.FindByText(dr["Condition"].ToString()).Selected = true;
                ddlCemetery.Items.FindByText(dr["Cemetery"].ToString()).Selected = true;
                //notes
                txtNotes.Text = dr["Notes"].ToString();
                //visit
                string strVisit = dr["VisitDate"].ToString();
                DateTime dtVisit = Convert.ToDateTime(strVisit);
                txtVisitMonth.Text = dtVisit.Month.ToString();
                txtVisitDay.Text = dtVisit.Day.ToString();
                txtVisitYear.Text = dtVisit.Year.ToString();

                ///////////////////////
                //Only logged in users can update or delete

                if (Session["LoggedIn"] != null && Session["LoggedIn"].ToString() == "1")
                {
                    btnAction.Text = "Update";
                    btnDelete.Visible = true;
                }
                else
                {
                    btnAction.Visible = false;
                    lblFeedback.Text = "Only users can edit the database: Please log in to do so.";
                }
            }

        }
        else
        {
            //default visiting date, set to current
            txtVisitMonth.Text = DateTime.Today.Month.ToString();
            txtVisitDay.Text = DateTime.Today.Day.ToString();
            txtVisitYear.Text = DateTime.Today.Year.ToString();
        }

    }

    protected void btnAction_Click(object sender, EventArgs e)
    {
        string strDOB = ""; string strDOD = ""; string strVisit = "";
        DateTime dtDOB, dtDOD, dtVisit;

        //clear feedback label
        lblFeedback.Text = "";

        //check if DOB is a date
        if (txtDOBDay.Text != "" &&
            txtDOBMonth.Text != "" &&
            txtDOBYear.Text != ""
            )
        {
            if (ValidationLibrary.DateCheck(txtDOBMonth.Text, txtDOBDay.Text, txtDOBYear.Text))
            {
                strDOB = txtDOBMonth.Text + "/" + txtDOBDay.Text + "/" + txtDOBYear.Text;
                dtDOB = Convert.ToDateTime(strDOB);
            }
            else
            {
                lblFeedback.Text = "Error: Invalid Format for DOB. <br />";
                dtDOB = DateTime.FromOADate(0);
            }
        }
        else
        {
            lblFeedback.Text = "Error: Incomplete DOB <br />";
            dtDOB = DateTime.FromOADate(0);
        }

        //check if DOD is a date
        if (txtDODDay.Text != "" &&
            txtDODMonth.Text != "" &&
            txtDODYear.Text != ""
            )
        {
            if (ValidationLibrary.DateCheck(txtDODMonth.Text, txtDODDay.Text, txtDODYear.Text))
            {
                strDOD = txtDODMonth.Text + "/" + txtDODDay.Text + "/" + txtDODYear.Text;
                dtDOD = Convert.ToDateTime(strDOD);
            }
            else
            {
                lblFeedback.Text = "Error: Invalid Format for DOD. <br />";
                dtDOD = DateTime.FromOADate(0);
            }
        }
        else
        {
            lblFeedback.Text = "Error: Incomplete DOD <br />";
            dtDOD = DateTime.FromOADate(0);
        }

        //check if Visit Time is a date
        if (txtVisitDay.Text != "" &&
            txtVisitMonth.Text != "" &&
            txtVisitYear.Text != ""
            )
        {
            if (ValidationLibrary.DateCheck(txtVisitMonth.Text, txtVisitDay.Text, txtVisitYear.Text))
            {
                strVisit = txtVisitMonth.Text + "/" + txtVisitDay.Text + "/" + txtVisitYear.Text;
                dtVisit = Convert.ToDateTime(strVisit);
            }
            else
            {
                lblFeedback.Text = "Error: Invalid Format for Visit Date. <br />";
                dtVisit = DateTime.FromOADate(0);
            }
        }
        else
        {
            lblFeedback.Text = "Error: Incomplete Visit Time <br />";
            dtVisit = DateTime.FromOADate(0);
        }


        //get the title
        string strTitle = "";
        if (rbtnMr.Checked) { strTitle = "Mr."; }
        else if (rbtnMs.Checked) { strTitle = "Ms."; }
        else if (rbtnMrs.Checked) { strTitle = "Mrs."; }
        else if (rbtnMiss.Checked) { strTitle = "Miss."; }
        else if (rbtnDr.Checked) { strTitle = "Dr."; }
        else if (rbtnRev.Checked) { strTitle = "Rev."; }

        //for adding
        if (btnAction.Text == "Add")
        {

        }

        //new instance of Grave for adding to db
        Grave Add = new Grave();

        Add.VisitDate = strVisit;
        Add.Dob = strDOB;
        Add.Dod = strDOD;
        Add.Feedback = "";
        Add.Cemetery = ddlCemetery.Text;
        Add.FName = txtFName.Text;
        Add.MName = txtMName.Text;
        Add.LName = txtLName.Text;
        Add.Title = strTitle;
        Add.Military = ddlMilitary.Text;
        Add.Condition = ddlStone.Text;
        Add.Notes = txtNotes.Text;

        lblFeedback.Text += Add.Feedback;
        
        if (lblFeedback.Text == "")
        {
            //prepare to add to database

            //for adding
            if (btnAction.Text == "Add")
            {
                lblFeedback.Text += Add.AddGrave();
            }
            else
            {
                lblFeedback.Text += Add.UpdateGrave(Request.QueryString["Grave_ID"]);
            }

        }
    }
    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //for deleteing
        Grave del = new Grave();
        lblFeedback.Text += del.DeleteGrave(Request.QueryString["Grave_ID"]);
    }
}
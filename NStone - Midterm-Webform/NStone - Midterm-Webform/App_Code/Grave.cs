using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;  // Library to connect to Access DB's
using System.Data;        // Library to bring in a dataset

public class Grave
{
    private string visitDate;
    private string cemetery;
    private string fName;
    private string mName;
    private string lName;
    private string title;
    private string dob;
    private string dod;
    private string military;
    private string condition;
    private string notes;

    private string feedback;
    private int test = 1;

    public string VisitDate
    {
        get { return visitDate; }
        set {
                DateTime dtVDay = Convert.ToDateTime(value);
                if (ValidationLibrary.DateInFuture(dtVDay)) 
                {
                    feedback += "Err";
                }
                else
                {
                    visitDate = value;
                }
            }
    }

    public string Cemetery
    {
        get { return cemetery; }
        set
        {
            if (!ValidationLibrary.IsFilledIn(value))
                feedback += "Error: This Grave needs a Cemetery. <br />";
            else
                cemetery = value;
        }
    }
    public string FName
    {
        get { return fName; }
        set
        {
            if (!ValidationLibrary.IsFilledIn(value))
                feedback += "Error: Empty First Name. <br />";
            else
                fName = value;
        }
    }
    public string MName
    {
        get { return mName; }
        set {  mName = value; }
    }
    public string LName
    {
        get { return lName; }
        set
        {
            if (!ValidationLibrary.IsFilledIn(value))
                feedback += "Error: Empty Last Name. <br />";
            else
                lName = value;
        }
    }
    public string Title
    {
        get  { return title;  }
        set
        {
            if (!ValidationLibrary.IsFilledIn(value))
                feedback += "Error: Empty Title, please choose 1. <br />";
            else
                title = value;
        }
    }
    public string Dob
    {
        get {  return dob;  }
        set
        {
            dob = value;
        }
        
    }
    public string Dod
    {
        get { return dod; }
        set
        {
            dod = value;
        }
    }
    public string Military
    {
        get  {  return military; }
        set
        {
            if (!ValidationLibrary.IsFilledIn(value))
                feedback += "Error: Empty military field. <br />";
            else
                military = value;
        }
    }
    public string Condition
    {
        get { return condition; }
        set
        {
            if (!ValidationLibrary.IsFilledIn(value))
                feedback += "Error: Emtpy condition. <br />";
            else
                condition = value;
        }
    }
    public string Notes
    {
        get { return notes; }
        set
        {  notes = value; }
    }
    public string Feedback
    {
        get { return feedback; }
        set { feedback = value; }
    }

    public string AddGrave()
    {
        string strFeedback = "";

        //parse out datetimes to string, because sql doesn't like to go too far back

        //Create SQL command string
        string strSQL = "INSERT INTO Gravestones2 " +
            "(VisitDate, Cemetery, FName, MName, LName, Title, Dob, Dod, Military, Condition, Notes) " +
            "VALUES " +
            "(@VisitDate, @Cemetery, @FName, @MName, @LName, @Title, @Dob, @Dod, @Military, @Condition, @Notes)";
        //create a connection to DB
        SqlConnection conn = new SqlConnection();

        string strConn = "Server=SQL.NEIT.EDU,4500;Database=SE255_nstone;User Id=SE255_nstone;Password=000972524;";
        conn.ConnectionString = strConn;

        //Bark out
        SqlCommand comm = new SqlCommand();
        comm.CommandText = strSQL; //command
        comm.Connection = conn; //connection

        //Paramters
        comm.Parameters.AddWithValue("@VisitDate", visitDate);
        comm.Parameters.AddWithValue("@Cemetery", cemetery);
        comm.Parameters.AddWithValue("@FName", fName);
        comm.Parameters.AddWithValue("@MName", mName);
        comm.Parameters.AddWithValue("@LName", lName);
        comm.Parameters.AddWithValue("@Title", title);
        comm.Parameters.AddWithValue("@Dob", dob);
        comm.Parameters.AddWithValue("@Dod", dod);
        comm.Parameters.AddWithValue("@Military", military);
        comm.Parameters.AddWithValue("@Condition", condition);
        comm.Parameters.AddWithValue("@Notes", Notes);

        try
        {
            //open
            conn.Open();

            //release command
            strFeedback = comm.ExecuteNonQuery().ToString() + " Grave Added";
        }
        catch (Exception err)
        {
            strFeedback = err.Message;
        }
        finally
        {
            conn.Close(); //Disconnect
        }
        return strFeedback;
    }

    public string UpdateGrave(string GravestoneID)
    {
        string strFeedback = "";
        

        //Create SQL command string
        string strSQL = "UPDATE Gravestones2 SET " +
            "VisitDate = @VisitDate, Cemetery = @Cemetery, FName = @FName, " +
            "MName = @MName, LName = @LName, Title = @Title, Dob = @Dob, " +
            "Dod = @Dod, Military = @Military, Condition = @Condition, Notes = @Notes " +
            "WHERE GravestoneID = @GravestoneID;";
        //create a connection to DB
        SqlConnection conn = new SqlConnection();

        string strConn = "Server=SQL.NEIT.EDU,4500;Database=SE255_nstone;User Id=SE255_nstone;Password=000972524;";
        conn.ConnectionString = strConn;

        //Bark out
        SqlCommand comm = new SqlCommand();
        comm.CommandText = strSQL; //command
        comm.Connection = conn; //connection

        //Paramters
        comm.Parameters.AddWithValue("@VisitDate", visitDate);
        comm.Parameters.AddWithValue("@Cemetery", cemetery);
        comm.Parameters.AddWithValue("@FName", fName);
        comm.Parameters.AddWithValue("@MName", mName);
        comm.Parameters.AddWithValue("@LName", lName);
        comm.Parameters.AddWithValue("@Title", title);
        comm.Parameters.AddWithValue("@Dob", dob);
        comm.Parameters.AddWithValue("@Dod", dod);
        comm.Parameters.AddWithValue("@Military", military);
        comm.Parameters.AddWithValue("@Condition", condition);
        comm.Parameters.AddWithValue("@Notes", Notes);
        comm.Parameters.AddWithValue("@GravestoneID", GravestoneID);

        try
        {
            //open
            conn.Open();

            //release command
            strFeedback = comm.ExecuteNonQuery().ToString() + " Grave Updated";
        }
        catch (Exception err)
        {
            strFeedback = err.Message;
        }
        finally
        {
            conn.Close(); //Disconnect
        }
        return strFeedback;

    }

    public string DeleteGrave(string GravestoneID)
    {
        string strFeedback = "";

        //Create SQL command string
        string strSQL = "DELETE FROM Gravestones2 WHERE GravestoneID = @GravestoneID;";
        //create a connection to DB
        SqlConnection conn = new SqlConnection();

        string strConn = "Server=SQL.NEIT.EDU,4500;Database=SE255_nstone;User Id=SE255_nstone;Password=000972524;";
        conn.ConnectionString = strConn;

        //Bark out
        SqlCommand comm = new SqlCommand();
        comm.CommandText = strSQL; //command
        comm.Connection = conn; //connection

        //Paramters
        comm.Parameters.AddWithValue("@GravestoneID", GravestoneID);

        try
        {
            //open
            conn.Open();

            //release command
            strFeedback = comm.ExecuteNonQuery().ToString() + " Grave Deleted";
        }
        catch (Exception err)
        {
            strFeedback = err.Message;
        }
        finally
        {
            conn.Close(); //Disconnect
        }
        return strFeedback;

    }

    public DataSet SearchGraves(string Cemetery, string FName, string LName)
    {
        //create a dataset to return filled
        DataSet ds = new DataSet();

        //init command
        SqlCommand comm = new SqlCommand();

        //write  select statement
        String strSQL = "SELECT * " +
                        "FROM Gravestones2 " +
                        "WHERE 0=0";
        //checks if search results had other parameters
        if (Cemetery.Length > 0)
        {
            strSQL += " AND Cemetery LIKE @Cemetery";
            comm.Parameters.AddWithValue("@Cemetery", "%" + Cemetery + "%");
        }
        if (FName.Length > 0)
        {
            strSQL += " AND FName LIKE @FName";
            comm.Parameters.AddWithValue("@FName", "%" + FName + "%");
        }
        if (LName.Length > 0)
        {
            strSQL += " AND LName LIKE @LName";
            comm.Parameters.AddWithValue("@LName", "%" + LName + "%");
        }

        //create DB tools
        SqlConnection conn = new SqlConnection();

        string strConn = "Server=SQL.NEIT.EDU,4500;Database=SE255_nstone;User Id=SE255_nstone;Password=000972524;";
        conn.ConnectionString = strConn;

        comm.Connection = conn;
        comm.CommandText = strSQL;

        //create data adapter
        SqlDataAdapter da = new SqlDataAdapter();
        da.SelectCommand = comm; //translator for commander to understand datasets

        //get data
        conn.Open();
        da.Fill(ds, "Gravestones");
        conn.Close();

        return ds;

    }

    public SqlDataReader FindGrave(int GraveID)
    {
        //tools
        SqlConnection conn = new SqlConnection();
        SqlCommand comm = new SqlCommand();

        string strConn = "Server=SQL.NEIT.EDU,4500;Database=SE255_nstone;User Id=SE255_nstone;Password=000972524;";
        string strSQL = "SELECT * FROM Gravestones2 WHERE GravestoneID = @GravestoneID";

        conn.ConnectionString = strConn;

        comm.Connection = conn;
        comm.CommandText = strSQL;
        comm.Parameters.AddWithValue("@GravestoneID", GraveID);

        conn.Open();

        return comm.ExecuteReader();
    }
}
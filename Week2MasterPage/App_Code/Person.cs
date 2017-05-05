using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;  // Library to connect to Access DB's
using System.Data;        // Library to bring in a dataset
//Remarked out because this is a website: using CodeValidator;
public class Person
{
    //declare private strings
    private string fName;
    private string mName;
    private string lName;
    private string street1;
    private string street2;
    private string city;
    private string state;
    private string zip;
    private string country;
    private string phone;
    private string email;
    private string birthday;
    private string anniversary;
    private string feedback;

    //used for our connection obj.
    //TEMP COMMENT
    //private SqlConnection conn;
    //private SqlCommand comm;

    //variables for min/max lengths
    const int stateMin = 2;
    const int zipMin = 5;
    const int countryMin = 4;
    const int countryMax = 28;
    const int phoneMin = 7;
    const int phoneMax = 20;
    const int bloodMin = 2;
    const int bloodMax = 3;

    //string used for feedback of errors
    public string Feedback
    {
        get { return feedback; }

        //no need to set, is called upon when errors apparein validation
    }

    public Int32 Person_ID = 0;

    //declare public strings that access the private strings
    public string FName
    {
        //get | accessor
        //returns the current value stored in the private string
        get { return fName; }

        //set | mutator
        //grabs values from public strings and changes the private string
        set
        {
            //this is used as a validator | if empty string
            if (Validate.IsFilledIn(value) == false)
                feedback += "Error: Empty entry in First Name" + "<br />";
            else
                fName = value;
        }
    }


    public string MName
    {
        get { return mName; }

        set { mName = value; }
    }

    public string LName
    {
        get { return lName; }

        set
        {
            if (Validate.IsFilledIn(value) == false)
                feedback += "Error: Empty entry in Last Name" + "<br />";
            else
                lName = value;
        }
    }

    public string Street1
    {
        get { return street1; }

        set { street1 = value; }
    }

    public string Street2
    {
        get { return street2; }

        set { street2 = value; }
    }

    public string City
    {
        get { return city; }

        set { city = value; }
    }

    public string State
    {
        get { return state; }

        set
        {
            if (value == "Select a State")
                feedback += "Error: Please enter a state" + "<br />";
            else
                state = value;
        }
    }

    public string Zip
    {
        get { return zip; }

        set
        {
            if (Validate.IsAtValidLength(value, zipMin) == false)
                feedback += "Error: Invalid length of zip, use 5 digits" + "<br />";
            else
                zip = value;
        }
    }

    public string Country
    {
        get { return country; }
        set
        {
            if (Validate.IsWithinValidLength(value, countryMin, countryMax) == false)
                feedback += "Error: Country input invalid" + "<br />";
            else
                country = value;
        }
    }

    public string Phone
    {
        get { return phone; }

        set
        {
            if (Validate.IsWithinValidLength(value, phoneMin, phoneMax) == false)
                feedback += "Error: Phone number too short" + "<br />";
            else
                phone = value;
        }
    }

    public string Email
    {
        get { return email; }

        set
        {
            if (Validate.IsValidEmail(value) == false)
                feedback += "Error: Not a valid Email" + "<br />";
            else
                email = value;
        }
    }

    //default contructor
    public Person()
    {
        feedback = "";
    }

    //overloaded constructor
    public Person(string strFirst, string strMid, string strLast, string strSt1, string strSt2,
                            string strCity, string strState, string strZip, string strCountry, string strPhone, string strEmail)
    {
        this.FName = strFirst;
        this.MName = strMid;
        this.LName = strLast;
        this.Street1 = strSt1;
        this.Street2 = strSt2;
        this.City = strCity;
        this.State = strState;
        this.Zip = strZip;
        this.Country = strCountry;
        this.Phone = strPhone;
        this.Email = strEmail;
        feedback = "";
    }

    /*function to connect db
    public string AddPerson()
    {
        string results = "";

        conn = new SqlConnection();
        string strConn = Utilities.NeitSQL();
        conn.ConnectionString = strConn;

        comm = new SqlCommand();

        //SQL Statment
        comm.CommandText = "INSERT INTO Persons (FName, MName, LName, Street1, Street2, City, State, Zip, Country, Phone, Email, BloodType) VALUES (@FName, @MName, @LName, @Street1, @Street2, @City, @State, @Zip, @Country, @Phone, @Email, @BloodType)";
        //Filling in paramerters
        comm.Parameters.AddWithValue("@FName", FName);
        comm.Parameters.AddWithValue("@MName", MName);
        comm.Parameters.AddWithValue("@LName", LName);
        comm.Parameters.AddWithValue("@Street1", Street1);
        comm.Parameters.AddWithValue("@Street2", Street2);
        comm.Parameters.AddWithValue("@City", City);
        comm.Parameters.AddWithValue("@State", State);
        comm.Parameters.AddWithValue("@Zip", Zip);
        comm.Parameters.AddWithValue("@Country", Country);
        comm.Parameters.AddWithValue("@Phone", Phone);
        comm.Parameters.AddWithValue("@Email", Email);
        comm.Parameters.AddWithValue("@BloodType", BloodType);
        //Connects to the right server
        comm.Connection = conn;

        try
        {
            conn.Open();
            //executes command
            int recCount = comm.ExecuteNonQuery();
            results = recCount.ToString() + " Records Added";




            conn.Close();
        }
        catch (Exception err)
        {
            results = "Error: " + err.Message;
        }
        finally
        {

        }

        return results;
    }

    public DataSet SearchContacts(string FName, string LName, bool intFormLoad)
    {
        //Create a dataset to return filled
        DataSet ds = new DataSet();

        //Create a command for out SQL statment
        SqlCommand comm = new SqlCommand();

        //Write a Select statement to perform Search
        String strSQL = "SELECT ";

        //Commented out, just old code to fiddle and learn. Would show the first 5 before searching.
        //if (intFormLoad == true)
        {
            //strSQL += "TOP 5";
        }

        strSQL += "Person_ID, FName, MName, LName FROM Persons WHERE 0=0";

        //if the first/last name is filled in include it as search criteria
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

        //Create DB tools and Configure
        //=========================================
        SqlConnection conn = new SqlConnection();

        //create the who, what, where of the DB
        string strConn = Utilities.NeitSQL();
        conn.ConnectionString = strConn;

        //Fill in basic info to command object
        comm.Connection = conn;  //tell the commander what connection to use
        comm.CommandText = strSQL; //tell the command what to say

        //Create DAta Adapter
        SqlDataAdapter da = new SqlDataAdapter();
        da.SelectCommand = comm; //commander needs a translator(dataAdaper) to peak with datasets
                                    //=========================================

        //Get data
        conn.Open();    //open the connection
        da.Fill(ds, "Persons"); //fill the dataset with results
        conn.Close();   //close the connection

        //return data
        return ds;
    }

    //Method that returns a Data Reader filled with all the data of one person. 
    //This one person is specifited by the ID passed to this function
    public SqlDataReader FindOnePerson(int intPerson_ID)
    {
        //Create and Initialize the DB Tools we need
        SqlConnection conn = new SqlConnection();
        SqlCommand comm = new SqlCommand();

        //My connection String
        string strConn = Utilities.NeitSQL();

        //My SQL command to pull up one person's data
        string sqlString = "SELECT * FROM Persons WHERE Person_ID =@Person_ID;";

        //Tell the connecion object the who, what, where, how
        conn.ConnectionString = strConn;

        //Give the command object info it needs
        comm.Connection = conn;
        comm.CommandText = sqlString;
        comm.Parameters.AddWithValue("@Person_ID", intPerson_ID);

        //open the DB connection and yell our sql command
        conn.Open();

        //Return some from of feedback
        return comm.ExecuteReader(); //Return the dataset to be used by others (the calling form)
    }

    public string UpdateContact(int intPerson_ID)
    {
        string strFeedback = "";

        conn = new SqlConnection();
        string strConn = Utilities.NeitSQL();
        conn.ConnectionString = strConn;

        comm = new SqlCommand();

        //SQL Statment
        comm.CommandText = "UPDATE Persons SET " +
            "FName = @FName, MName = @MName, LName = @LName, " +
            "Street1 = @Street1, Street2 = @Street2, City = @City, " +
            "State = @State, Zip = @Zip, Country = @Country, " +
            "Phone = @Phone, Email = @Email, BloodType = @BloodType " +
            "WHERE Person_ID = @Person_ID;";
        //Filling in paramerters
        comm.Parameters.AddWithValue("@FName", FName);
        comm.Parameters.AddWithValue("@MName", MName);
        comm.Parameters.AddWithValue("@LName", LName);
        comm.Parameters.AddWithValue("@Street1", Street1);
        comm.Parameters.AddWithValue("@Street2", Street2);
        comm.Parameters.AddWithValue("@City", City);
        comm.Parameters.AddWithValue("@State", State);
        comm.Parameters.AddWithValue("@Zip", Zip);
        comm.Parameters.AddWithValue("@Country", Country);
        comm.Parameters.AddWithValue("@Phone", Phone);
        comm.Parameters.AddWithValue("@Email", Email);
        comm.Parameters.AddWithValue("@BloodType", BloodType);
        comm.Parameters.AddWithValue("@Person_ID", intPerson_ID);
        //Connects to the right server
        comm.Connection = conn;

        try
        {
            conn.Open();
            //executes command
            int recCount = comm.ExecuteNonQuery();
            strFeedback = recCount.ToString() + " Records Added";




            conn.Close();
        }
        catch (Exception err)
        {
            strFeedback = "Error: " + err.Message;
        }
        finally
        {

        }

        return strFeedback;
    }

    public Int32 DeleteOnePerson(int intPerson_ID)
    {
        Int32 intRecords = 0;

        conn = new SqlConnection();
        string strConn = Utilities.NeitSQL();
        conn.ConnectionString = strConn;

        comm = new SqlCommand();

        //My SQL command string to pull up one person's data
        string sqlString =
        "DELETE FROM Persons WHERE Person_ID = @Person_ID;";

        //Tell the connection object the who, what, where, how
        conn.ConnectionString = strConn;

        //Give the command object info it needs
        comm.Connection = conn;
        comm.CommandText = sqlString;
        comm.Parameters.AddWithValue("@Person_ID", intPerson_ID);

        //Open the DataBase Connection and Yell our SQL Command
        conn.Open();

        //Run the deletion and store the number of records effected
        intRecords = comm.ExecuteNonQuery();

        DialogResult result1 = MessageBox.Show("DELETE " + intRecords.ToString() + "Records?", "Deleteing files", MessageBoxButtons.YesNo);

        //close the connection
        conn.Close();

        return intRecords;   //Return # of records deleted

    }*/
}

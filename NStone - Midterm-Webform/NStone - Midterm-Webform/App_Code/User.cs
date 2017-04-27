using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;  // Library to connect to Access DB's
using System.Data;        // Library to bring in a dataset


public class User
{
    public SqlDataReader FindUser(string UName, string PW)
    {
        //Create and Initialize the DB Tools we need
        SqlConnection conn = new SqlConnection();
        SqlCommand comm = new SqlCommand();

        //My connection String
        string strConn = "Server=SQL.NEIT.EDU,4500;Database=SE255_nstone;User Id=SE255_nstone;Password=000972524;";

        //My SQL command to pull up one person's data
        string sqlString = "SELECT * FROM Users WHERE UName =@Uname AND PW =@PW;";

        //Tell the connecion object the who, what, where, how
        conn.ConnectionString = strConn;

        //Give the command object info it needs
        comm.Connection = conn;
        comm.CommandText = sqlString;
        comm.Parameters.AddWithValue("@UName", UName);
        comm.Parameters.AddWithValue("@PW", PW);

        //open the DB connection and yell our sql command
        conn.Open();

        //Return some from of feedback
        return comm.ExecuteReader(); //Return the dataset to be used by others (the calling form)
    }

}
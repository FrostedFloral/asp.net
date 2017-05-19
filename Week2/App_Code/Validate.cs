using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Validate
/// </summary>
public class Validate
{
    public static bool GotPoop(string temp)
    {
        bool result = false;
        temp.ToLower();

        if (temp.Contains("poop"))
        {
            result = true;
        }

        return result;
    }

    /*
     * Library of validation functions we can use in future projects
     * */

    //reveives a string and we can let user know if it is filled in
    public static bool IsFilledIn(string temp)
    {
        bool result = false;

        if (temp.Length > 0)
        {
            result = true;
        }

        return result;
    }

    //reveives a string and we can let user know if it is filled in at length
    public static bool IsAtValidLength(string temp, int minlength)
    {
        bool result = false;

        if (temp.Length == minlength)
        {
            result = true;
        }

        return result;
    }

    //test string to be within the minlength and the max length
    public static bool IsWithinValidLength(string temp, int minlength, int maxlength)
    {
        bool result = false;

        if (temp.Length >= minlength &&
            temp.Length <= maxlength)
        {
            result = true;
        }

        return result;
    }

    //receives a string and we can let user know if it has a semi-valid email format
    public static bool IsValidEmail(string temp)
    {
        //assume true, but look for bad stuff to make false
        bool result = true;

        //look for position of "@"
        int atLocation = temp.IndexOf("@");
        int NextatLocation = temp.IndexOf("@", atLocation + 1);

        //look for position of last "."
        int periodLocation = temp.LastIndexOf(".");

        //check for min length
        if (temp.Length < 8)
        {
            result = false;
        }
        else if (atLocation < 2) //at least 2 characters before "@"
        {
            result = false;
        }
        else if (periodLocation + 2 > (temp.Length)) //at least 2 characters after last "."
        {
            result = false;
        }

        return result;
    }
}
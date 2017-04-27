using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ValidationLibrary
/// </summary>
public class ValidationLibrary
{
    public static bool IsFilledIn(string temp)
    //reveives a string and we can let user know if it is filled in
    {
        bool result = false;

        if (temp.Length > 0)
        {
            result = true;
        }

        return result;
    }

    public static bool IsAtValidLength(string temp, int minlength)
    //reveives a string and we can let user know if it is filled in at length
    {
        bool result = false;

        if (temp.Length == minlength)
        {
            result = true;
        }

        return result;
    }

    public static bool IsWithinValidLength(string temp, int minlength, int maxlength)
    //test string to be within the minlength and the max length
    {
        bool result = false;

        if (temp.Length >= minlength &&
            temp.Length <= maxlength)
        {
            result = true;
        }

        return result;
    }


    public static bool IsValidEmail(string temp)
    //receives a string and we can let user know if it has a semi-valid email format
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

    public static bool DateInFuture(DateTime temp)
    //checks a date if it's a date in the future
    {
        bool result = true;
        DateTime today = DateTime.Now;
        if (temp.Date.ToOADate() <= today.Date.ToOADate())
        {
            result = false;
        }
        return result;
    }

    public static bool DateCheck(string Month, string Day, string Year)
    {
        int intMonth = Convert.ToInt32(Month);
        int intDay = Convert.ToInt32(Day);
        int intYear = Convert.ToInt32(Year);
        bool results = false;

        if (intYear <= 9999)
        {
             if (intMonth <= 12 && intMonth >= 1)
            {
                if (intMonth == 2)
                {
                    if (intDay <= 29 && intDay >= 1)
                    { results = true; }
                }
                else
                {
                    if (intDay <= 31 && intDay >= 1)
                    { results = true; }
                }
            }
        }
        return results;
    }


}
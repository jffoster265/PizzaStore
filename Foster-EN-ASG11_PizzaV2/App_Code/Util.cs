using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// General methods that might be used in PikesPizza but do not belong to a specific class
/// </summary>
public static class Util
{
    
    // Get the status if the 
    public static  String getLogInStatus()
    {
        String status = "";
        //HttpContext.Current.Session.Abandon();



        if (HttpContext.Current.Session["User"] != null)
        {
            User user = new User();
            // Notice to make use of the SESSION in this class must use:
            //  HttpContext.Current.Session  This is the global session object that is

            user = (User)HttpContext.Current.Session["User"];
            status = "Welcome back  " + user.FirstName + " " + user.LastName;


        }

        return status;
        
    }

    public static Boolean isLoggedIn()
    {
        bool loggedIn = false;
       

        if (HttpContext.Current.Session["User"] != null)
        {
            User user = new User();
            // Notice to make use of the SESSION in this class must use:
            //  HttpContext.Current.Session  This is the global session object that is

            user = (User)HttpContext.Current.Session["User"];

            
            loggedIn = true;

        }

        return loggedIn;
    }

   
}
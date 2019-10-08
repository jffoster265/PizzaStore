using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Used for Non class based Database Calls for PikesPizza
/// </summary>
public class DataBase
{
    public DataBase()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    // Used to connect to the database
    public static String getConnectionString()
    {
        return ConfigurationManager.ConnectionStrings["ConnectionStringPikesPizza"].ConnectionString;
    }






}
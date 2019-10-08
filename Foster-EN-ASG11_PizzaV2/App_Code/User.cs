using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Used for User Object for PikesPizza
/// </summary>
public class User
{
    //private int id;
    //private String userName;
    //private String email;
    //private String password;
    //private String firstName;
    //private String lastName;

    public User()
    {
        this.ID = -1; // Default UserID = -1
    }

    public int ID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int RoleID { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }
    public string Address1 { get; set; }
    public string City { get; set; }
    public string St { get; set; }
    public string Zip { get; set; }
    public bool isActive { get; set; }

}
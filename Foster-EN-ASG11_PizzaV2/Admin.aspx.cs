using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Util.isLoggedIn() == true)
        {
            //check role Id
            User user = (User)HttpContext.Current.Session["User"];
            if (user.RoleID < 0)
                Response.Redirect("Login.aspx");
            else if (user.RoleID == 1)
                Response.Redirect("Order.aspx");
        }
        else
        {
            Response.Redirect("Default.aspx");
        }


    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    private object lblStatus;

    protected void Page_Load(object sender, EventArgs e)
    {
        
    }



    protected void btnLogin_Click(object sender, EventArgs e)
    {
        String userName = txtUserName.Text;
        String password = txtPassword.Text;
        User user;
       
        user = UserDB.getUserFromEmailPassword(userName, password);

        if (user.ID > 0 && user.RoleID == 1)
        {
            Session.Clear();
            Session.Add("User", user);
    
                lblStatus = "Welcome " + user.FirstName;
                Response.Redirect("Order.aspx");
        }
        if(user.ID > 0 && user.RoleID > 1)
        {
            Session.Clear();
            Session.Add("User", user);

            lblStatus = "Welcome " + user.FirstName + ",you are logged on as an administrator";
            Response.Redirect("Admin.aspx");
        }
            else
            {
                lblLoginStatus.Text = "Invalid login. Please try again.";
            }

        
    }
}
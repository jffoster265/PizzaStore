using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ListOfUsers : System.Web.UI.Page
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
            else
            {
                // User user = new User();
                user = (User)Session["User"];

                List<User> listOfUsers = new List<User>();
                listOfUsers = UserDB.getAllUsers();

                GridView1.DataSource = listOfUsers;
                GridView1.DataBind();
            }

        }
        else
        {
            Response.Redirect("Default.aspx");
        }
    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        int id = int.Parse(GridView1.SelectedRow.Cells[1].Text);

        User newUser = UserDB.getUserById(id);
        Session.Add("newUser", newUser);
        Response.Redirect("EditUser.aspx");


    }
}

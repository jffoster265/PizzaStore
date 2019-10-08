using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class EditUser : System.Web.UI.Page
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
        fillCustomerUpdateForm();
    }

    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        Boolean isValid = true;
        String firstName = txtFirstName.Text;
        String lastName = txtLastName.Text;
        String address = txtAddress.Text;
        String email = txtEmail.Text;
        String city = txtCity.Text;
        String state = txtState.Text;
        String zip = txtZip.Text;
        String isActive = ddListIsActive.Text;

        if (isValid)
        {
            User user = new User();
            user.FirstName = txtFirstName.Text;
            user.LastName = txtLastName.Text;
            user.Address1 = txtAddress.Text;
            user.Email = txtEmail.Text;
            user.City = txtCity.Text;
            user.St = txtState.Text;
            user.Zip = txtZip.Text;
            //user.RoleID = ddListRoles;
            //user.isActive = ddListIsActive.Text;
            UserDB.updateUser(user);
        }

    }

    private void fillCustomerUpdateForm()
    {
        User user = (User)HttpContext.Current.Session["newUser"];

        if (user.RoleID == 1)
            ddListRoles.Text = "End User";
        else
            ddListRoles.Text = "Admin";

        if (user.isActive)
            ddListIsActive.Text = "Active";
        else
            ddListIsActive.Text = "Deleted";

        txtFirstName.Text = user.FirstName.ToString();
        txtLastName.Text = user.LastName.ToString();
        txtAddress.Text = user.Address1.ToString();
        txtEmail.Text = user.Email.ToString();
        txtCity.Text = user.City.ToString();
        txtState.Text = user.St.ToString();
        txtZip.Text = user.Zip.ToString();
    }
}
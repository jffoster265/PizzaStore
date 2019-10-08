using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default5 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void processRegistration(object sender, EventArgs e)
    {
        bool isValid = true;
        String firstName = txtFirstName.Text;
        String lastName = txtLastName.Text;
        String email = txtEmail.Text;
        String address = txtAddress.Text;
        String city = txtCity.Text;
        String state = txtState.Text;
        String zipCode = txtZip.Text;
        String userName = txtUsername.Text;
        String password = txtPassword.Text;
        String confirmPassword = txtConfirmPassword.Text;
        String message = lblMessage.Text;

        if(firstName.Equals(""))
        {
            isValid = false;
            lblMessage.Text = "Please enter your first name.";
        }
        if (lastName.Equals(""))
        {
            isValid = false;
            lblMessage.Text = "Please enter your last name.";
        }
        if (email.Equals(""))
        {
            isValid = false;
            lblMessage.Text = "Please enter your email address.";
        }
        if (address.Equals(""))
        {
            isValid = false;
            lblMessage.Text = "Please enter your address.";
        }
        if (city.Equals(""))
        {
            isValid = false;
            lblMessage.Text = "Please enter your city";
        }
        if (state.Equals(""))
        {
            isValid = false;
            lblMessage.Text = "Please enter your state.";
        }
   
        if (zipCode.Equals(""))
        {
            isValid = false;
            lblMessage.Text = "Please enter your zip code.";
        }

        if (userName.Equals(""))
        {
            isValid = false;
            lblMessage.Text = "Please choose a username";
        }
        if (password.Equals(""))
        {
            isValid = false;
            lblMessage.Text = "Please enter your password";
        }
        if(password != confirmPassword)
        {
            isValid = false;
            lblMessage.Text = "Passwords must match";
        }

        if (isValid)
        {
            User user = new User();
            user.FirstName = txtFirstName.Text;
            user.LastName = txtLastName.Text;
            user.Email = txtEmail.Text;
            user.Address1 = txtAddress.Text;
            user.City = txtCity.Text;
            user.St = txtState.Text;
            user.Zip = txtZip.Text;
            user.UserName = txtUsername.Text;
            user.Password = txtPassword.Text;

            user = UserDB.insertUser(user);

            if(user.ID > 0)
            {
                Session.Clear();
                Session.Add("User", user);

                lblMessage.Text = "Record Inserted!!";
                //Response.Redirect("register.aspx");

            }
            else
            {
                lblMessage.Text = "Error Inserting Record";
            }
        }

    }
}
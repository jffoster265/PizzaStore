using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static ProductDb;

public partial class Default3 : System.Web.UI.Page
{


    protected void Page_Load(object sender, EventArgs e)
    {

        if (Util.isLoggedIn() == false)
        {
            Response.Redirect("Default.aspx");
        }
        else
        {
            if (IsPostBack)
            {
                placeOrder();
            }
            else
            {
                loadPizzaDropDowns();
            }
        }

    }

    protected void loadPizzaDropDowns()
    {
        // Fill a dropDownList From the database
        DropDownList ddlProducts = ProductDB.getListOfProducts();

        DropDownListPizza1.Items.Clear();
        DropDownListPizza2.Items.Clear();
        DropDownListPizza3.Items.Clear();


        // Add the first item into the drop down list
        ListItem defaultItem = new ListItem("Please Select A Yummy Pizza", "0");
        DropDownListPizza1.Items.Add(defaultItem);
        DropDownListPizza2.Items.Add(defaultItem);
        DropDownListPizza3.Items.Add(defaultItem);


        // Fill each drop down list with all the products
        foreach (ListItem item in ddlProducts.Items)
        {
            DropDownListPizza1.Items.Add(item);
            DropDownListPizza2.Items.Add(item);
            DropDownListPizza3.Items.Add(item);
        }

    }

    protected void placeOrder()
    {
        int pizza1ID = -1;
        int pizza2ID = -1;
        int pizza3ID = -1;

        int.TryParse(DropDownListPizza1.SelectedValue, out pizza1ID);
        int.TryParse(DropDownListPizza2.SelectedValue, out pizza2ID);
        int.TryParse(DropDownListPizza3.SelectedValue, out pizza3ID);

        int userID = -1;

        //Check to see if user is in session
        if(Session["User"] != null)
        {
            User user = (User)Session["User"];
            userID = user.ID;

            if(pizza1ID > 0 || pizza2ID > 0 || pizza3ID > 0 && userID > 0)
            {
                    int orderID = -1;
                    orderID = OrderDB.insertOrderRecord(userID);

                    if(orderID > 0)
                    {
                        if(pizza1ID > 0)
                            OrderDB.insertOrderItem(orderID, pizza1ID);

                        if (pizza2ID > 0)
                            OrderDB.insertOrderItem(orderID, pizza2ID);

                        if (pizza3ID > 0)
                            OrderDB.insertOrderItem(orderID, pizza3ID);

                            Response.Redirect("OrderHistory.aspx");

                    }
            }
        }
    }



    protected void btnSubmitOrder_Click(object sender, EventArgs e)
    {
        //placeOrder();
    }

    private int getUserIDFromSession()
    {
        int userID = -1;

        if(HttpContext.Current.Session["user"] != null)
        {
            User user = new User();

            user = (User)HttpContext.Current.Session["user"];

            if(user.ID > 0)
            {
                userID = user.ID;
            }
        }
        else
        {
            userID = -1;
            Response.Redirect("Login.aspx");
        }

        return userID;

    }
}
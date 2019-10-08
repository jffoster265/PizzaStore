using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default4 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(Util.isLoggedIn() == false)
        {
            Response.Redirect("Default.aspx");
        }
        else
        {
            User user = new User();
            user = (User)Session["User"];

            List<OrderHistory> listOrderHistory = new List<OrderHistory>();
            listOrderHistory = OrderDB.getOrderHistoryForUser(user.ID);



            //repeaterOrderHistory.DataSource = listOrderHistory;
            //repeaterOrderHistory.DataBind();

            GridView1.DataSource = listOrderHistory;
            GridView1.DataBind();
        }

    }
}
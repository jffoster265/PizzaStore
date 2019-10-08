using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Used for Database Calles for the Order Object
/// </summary>
public static class OrderDB
{
    public static int insertOrderRecord(int userID)
    {
        // Insert an Order record and return the Order.ID
        // The Order.ID is needed so we can insert OrderItem records

        int orderID = -1;

        String insertSQL = "insert into [order] " +
                           "(userID, orderDate) " +
                           "values(@UserID,  GetDate()); select cast(SCOPE_IDENTITY() as int);";
        using (SqlConnection pizzaConnection = new SqlConnection(DataBase.getConnectionString()))
        {
            using (SqlCommand pizzaCommand = new SqlCommand(insertSQL, pizzaConnection))
            {
                pizzaCommand.Parameters.AddWithValue("UserID", userID);
                pizzaConnection.Open();
                // ExecuteScaler will return the first column of the first record in the SQL.
                // In this case because the SQL statement execute:  select cast(SCOPE_IDENTITY() as int)
                // This will return the OrderID of the record just inserted. 
                orderID = (int)pizzaCommand.ExecuteScalar();
            }
        }
        return orderID;
    }

    public static void insertOrderItem(int orderID, int productID)
    {
        String insertSQL = "insert into orderItem " +
                           "(orderID, productID, orderPrice) " +
                           "values(@orderID, @productID, (select listPrice from product where id = @productID))";
        // Note orderPrice is a terrible name for the field, it should be orderItemPrice
        using (SqlConnection pizzaConnection = new SqlConnection(DataBase.getConnectionString()))
        {
            using (SqlCommand pizzaCommand = new SqlCommand(insertSQL, pizzaConnection))
            {
                pizzaCommand.Parameters.AddWithValue("orderID", orderID);
                pizzaCommand.Parameters.AddWithValue("productID", productID);
                pizzaConnection.Open();
                // ExecuteScaler will return the first column of the first record in the SQL.
                // In this case because the SQL statement execute:  select cast(SCOPE_IDENTITY() as int)
                // This will return the OrderID of the record just inserted. 
                pizzaCommand.ExecuteScalar();
            }
        }
    }



    public static List<OrderHistory> getOrderHistoryForUser(int userID)
    {
        List<OrderHistory> listOrderHistory = new List<OrderHistory>();
        SqlDataReader dataReader;
        string sql = "spUserOrderList";

        using (SqlConnection conn = new SqlConnection(DataBase.getConnectionString()))
        {
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("UserID", userID);

                conn.Open();
                dataReader = cmd.ExecuteReader();


                while (dataReader.Read())
                {
                    OrderHistory orderHistory = new OrderHistory();


                    orderHistory.UserID = (int)dataReader["UserID"];
                    orderHistory.FirstName = dataReader["FirstName"].ToString();
                    orderHistory.LastName = dataReader["LastName"].ToString();
                    orderHistory.OrderID = (int)dataReader["OrderID"];
                    orderHistory.OrderDate = dataReader["OrderDate"].ToString();
                    orderHistory.OrderItemID = (int)dataReader["OrderItemID"];
                    orderHistory.ProductName = dataReader["ProductName"].ToString();
                    orderHistory.ItemPrice = (decimal)dataReader["ListPrice"];

                    listOrderHistory.Add(orderHistory);

                }
                conn.Close();
            }

        }

        return listOrderHistory;

    }

}
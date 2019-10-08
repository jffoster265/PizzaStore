using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for OrderHistory
/// </summary>
public class OrderHistory
{
    public int UserID { get; set; }
    public String FirstName { get; set; }
    public String LastName { get; set; }
    public int OrderID { get; set; }
    public String OrderDate { get; set; }
    public int OrderItemID { get; set; }
    public String ProductName { get; set; }
    public Decimal ItemPrice { get; set; }

    public OrderHistory()
    {
        //
        // TODO: Add constructor logic here
        //
    }
}
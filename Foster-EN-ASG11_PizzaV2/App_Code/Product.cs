using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Product
/// </summary>
public class Product
{
    public Product()
    {
        this.ID = -1;
    }
    public int ID { get; set; }
    public string PoductCode { get; set; }
    public string ProductName { get; set; }
    public string ListPrice { get; set; }
    public bool isActive { get; set; }
}
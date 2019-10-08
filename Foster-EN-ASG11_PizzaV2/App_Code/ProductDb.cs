using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

/// <summary>
/// Summary description for ProductDb
/// </summary>
public class ProductDb
{
    public static class ProductDB
    {
        public static DropDownList getListOfProducts()
        {
            DropDownList dropDownListProducts = new DropDownList();

            dropDownListProducts.Items.Clear();


            SqlDataReader dataReader;
            //string sql = "select ID, productName, listPrice from product where isActive = 1 order by id";
            string sql = "select ID, productName, listPrice from product order by id";
            using (SqlConnection conn = new SqlConnection(DataBase.getConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    conn.Open();
                    dataReader = cmd.ExecuteReader();
                    ListItem item;

                    while (dataReader.Read())
                    {
                        item = new ListItem(); // Need a new item
                                               // To add to a dropdown list, you need to add an Item which has a Text and Value property

                        item.Text = dataReader["productName"].ToString() + "  " + dataReader["listPrice"].ToString();
                        item.Value = dataReader["ID"].ToString();

                        dropDownListProducts.Items.Add(item);

                    }
                    conn.Close();
                }



            }

            return dropDownListProducts;
        }
    }

}
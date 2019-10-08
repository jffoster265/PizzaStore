using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
///  Used for Database Calles for the User Object
/// </summary>
public static class UserDB
{
    public static User getUserFromEmailPassword(string email, string password)
    {
        User user = new User();


        SqlDataReader dataReader;
        string sql = "select * from [user] where email = @email  and password = @password";

        using (SqlConnection conn = new SqlConnection(DataBase.getConnectionString()))
        {
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("email", email);
                cmd.Parameters.AddWithValue("password", password);
                conn.Open();
                dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    user.ID = (int)dataReader["ID"];
                    user.RoleID = (int)dataReader["roleID"];
                    user.FirstName = dataReader["firstName"].ToString();
                    user.LastName = dataReader["lastName"].ToString();
                    user.Email = dataReader["email"].ToString();
                    user.UserName = dataReader["userName"].ToString();
                    user.Password = dataReader["password"].ToString();

                }
                conn.Close();
            }

            return user;

        }
    }

    public static User getUserById(int id)
    {
        User user = new User();

        SqlDataReader dataReader;
        string sql = "select * from [user] where id = @id";

        using (SqlConnection conn = new SqlConnection(DataBase.getConnectionString()))
        {
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("id", id);
                conn.Open();
                dataReader = cmd.ExecuteReader();
            }
            while (dataReader.Read())
            {
                user.ID = (int)dataReader["ID"];
                user.RoleID = (int)dataReader["roleID"];
                user.FirstName = dataReader["firstName"].ToString();
                user.LastName = dataReader["lastName"].ToString();
                user.Email = dataReader["email"].ToString();
                user.Address1 = dataReader["address1"].ToString();
                user.City = dataReader["city"].ToString();
                user.St = dataReader["st"].ToString();
                user.Zip = dataReader["zip"].ToString();
                user.isActive = (bool)dataReader["isActive"];
            }
        }
            return user;
    }

    public static User insertUser(User user)
    {


        String insertSQL = "insert into [user] " +
                   " (userName, password, email, address1, city, st, zip, firstName, lastName, roleID, isActive) " +
                   " values(@userName,  @password, @email, @addressOne, @city, @state, @zip, @firstname, @lastname, 1, 1  ); " +
                   " select cast(SCOPE_IDENTITY() as int);";
        using (SqlConnection conn = new SqlConnection(DataBase.getConnectionString()))
        {
            using (SqlCommand cmd = new SqlCommand(insertSQL, conn))
            {
                cmd.Parameters.AddWithValue("userName", user.UserName);
                cmd.Parameters.AddWithValue("password", user.Password);
                cmd.Parameters.AddWithValue("email", user.Email);
                cmd.Parameters.AddWithValue("addressOne", user.Address1);
                cmd.Parameters.AddWithValue("city", user.City);
                cmd.Parameters.AddWithValue("state", user.St);
                cmd.Parameters.AddWithValue("zip", user.Zip);
                cmd.Parameters.AddWithValue("firstname", user.FirstName);
                cmd.Parameters.AddWithValue("lastname", user.LastName);
                conn.Open();
                // ExecuteScaler will return the first column of the first record in the SQL.
                // In this case because the SQL statement execute:  select cast(SCOPE_IDENTITY() as int)
                // This will return the ID of the record just inserted. 
                user.ID = (int)cmd.ExecuteScalar();
                user.isActive = true;
                user.RoleID = 1;

            }
        }

        return user;

    }

    public static User updateUser(User user)
    {

        String updateSql = "Update [User] SET "
                            + "firstName = ?, "
                            + "lastName = ?, "
                            + "roleID = ?, "
                            + "address1 = ?, "
                            + "city = ?, "
                            + "st = ?, "
                            + "zip = ?, "
                            + "email = ?,"
                            + "isActive = ?";
        using (SqlConnection conn = new SqlConnection(DataBase.getConnectionString()))
        {
            using (SqlCommand cmd = new SqlCommand(updateSql, conn))
            {
                cmd.Parameters.AddWithValue("firstname", user.FirstName);
                cmd.Parameters.AddWithValue("lastname", user.LastName);
                cmd.Parameters.AddWithValue("roleID", user.RoleID);
                cmd.Parameters.AddWithValue("addressOne", user.Address1);
                cmd.Parameters.AddWithValue("city", user.City);
                cmd.Parameters.AddWithValue("state", user.St);
                cmd.Parameters.AddWithValue("zip", user.Zip);
                cmd.Parameters.AddWithValue("email", user.Email);
                cmd.Parameters.AddWithValue("isActive", user.isActive);

                conn.Open();
                

            }
        }



        return user;
    }

    public static List<User> getAllUsers()
    {
        List<User> listOfUsers = new List<User>();
        SqlDataReader dataReader;
        string sql = "spUserList";

        using (SqlConnection conn = new SqlConnection(DataBase.getConnectionString()))
        {
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                conn.Open();
                dataReader = cmd.ExecuteReader();
            }
            while (dataReader.Read())
            {
                User user = new User();


                user.ID = (int)dataReader["ID"];
                user.FirstName = dataReader["FirstName"].ToString();
                user.LastName = dataReader["LastName"].ToString();
                user.Address1 = dataReader["Address1"].ToString();
                user.City = dataReader["City"].ToString();
                user.St = dataReader["St"].ToString();
                user.Zip = dataReader["Zip"].ToString();
                user.UserName = dataReader["UserName"].ToString();
                user.Password = dataReader["Password"].ToString();
                user.Email = dataReader["Email"].ToString();
                user.RoleID = (int)dataReader["RoleID"];
                user.isActive = (bool)dataReader["isActive"];


                listOfUsers.Add(user);

            }
            conn.Close();
        }
        return listOfUsers;
    }

   

}
      
  


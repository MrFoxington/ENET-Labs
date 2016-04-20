using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Lab5
{
    public class Class1
    {


        public void getData()
        {
            using (SqlConnection c = new SqlConnection())
            {

                c.ConnectionString = ConfigurationManager.ConnectionStrings["Db"].ConnectionString;

                string query = @"SELECT * FROM Foods";
                SqlCommand command = new SqlCommand(query);
                command.Connection = c;

                command.ExecuteReader();

            }



        }
       

    }
}
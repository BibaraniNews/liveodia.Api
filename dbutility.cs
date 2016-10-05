using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using LiveOdia.APi.Models;

namespace LiveOdia.APi
{
    public class dbutility
    {
        public static DataTable getAllRecord()
        {
            MySqlConnection conn = new MySqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["MyLocalDb"].ConnectionString);
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                string query = "SELECT * FROM topnews";
                MySqlCommand cmd = new MySqlCommand(query, conn);


                dt.Load(cmd.ExecuteReader());
            }
            catch (Exception ex)
            {

            }
            return dt;
        }

        public static bool addNewCategory(AdminModel value)
        {
            MySqlConnection conn = new MySqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["MyLocalDb"].ConnectionString);
            bool res = false;
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                conn.Open();
                cmd.CommandText= "INSERT INTO newsdivision (newsdiv) VALUES (@newsdiv)";
                cmd.Parameters.AddWithValue("newsdiv", value.CNAME);
                cmd.Connection = conn;
                cmd.Prepare();
                cmd.ExecuteNonQuery();
                res = true;
            }
            catch (Exception ex)
            {
                res = false;
            }
            return res;

        }

        public static void SaveData(Dictionary<string, object> myData)
        {
            MySqlConnection conn = new MySqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["MyLocalDb"].ConnectionString);
            bool res = false;
            try
            {

                foreach (var key in myData) {

                }

                MySqlCommand cmd = new MySqlCommand();
                conn.Open();
                cmd.CommandText = "INSERT INTO newsdivision (newsdiv) VALUES (@newsdiv)";
                cmd.Parameters.AddWithValue("newsdiv", myData.Keys);
                cmd.Connection = conn;
                cmd.Prepare();
                cmd.ExecuteNonQuery();
                res = true;
            }
            catch (Exception ex)
            {
                res = false;
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using MySql.Data.MySqlClient;
namespace atestat
{
    //test
    public class userManager
    {
       public MySqlConnection conn = null;
        public void init()
        {
            //initiate the conneciton 
            string connstring = @"server=localhost;userid=root;password=;database=atestat";
            try
            {
                conn = new MySqlConnection(connstring);
                
            }
            catch
            {
                System.Diagnostics.Debug.WriteLine("Connection error");
            }
        }
        public void close()
        {
            conn.Close();
        }
        public int login_user(String name, String pass)
        {
            String query = "SELECT id FROM elevi where username = '" + name + "' AND parola = '"+ pass +"' ";

            MySqlDataAdapter da = new MySqlDataAdapter(query, conn);

            System.Data.DataSet ds = new DataSet();
            da.Fill(ds, "elevi");
            DataTable dt = ds.Tables["elevi"];

            if (dt.Rows.Count==0)
            return 0;
            else
            {
                System.Diagnostics.Debug.WriteLine(Int32.Parse(dt.Rows[0][0].ToString()));

                return Int32.Parse(dt.Rows[0][0].ToString());
            }
        }
    }
}

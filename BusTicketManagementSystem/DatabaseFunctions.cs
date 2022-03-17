using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusTicketManagementSystem
{
    internal class DatabaseFunctions
    {
        // Connection String
        protected SqlConnection GetConnection()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=BusTicketManagementSystem;Integrated Security=True";
            return con;
        }

        // Method to get data from database (SELECT)
        public SqlDataReader GetData(string query)
        {
            SqlConnection con = GetConnection();

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                return cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            return null;
        }


        // Method to set data in database (INSERT, UPDATE, DELETE)
        public void SetData(string query)
        {
            SqlConnection con = GetConnection();

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}

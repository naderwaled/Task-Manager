using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace Task_Manager
{
  public  class database
    {
       public void insrtintodatabase(string quary)
        {
            String road = @"Data Source=DESKTOP-T7ORQ8E\\SQLEXPRESS;Initial Catalog=TASK_MANAGER;Integrated Security=True";
            SqlConnection connect = new SqlConnection(road);
            SqlCommand cmd = new SqlCommand(quary, connect);
            try
            {
                connect.Open();
                SqlDataReader reader;
                reader = cmd.ExecuteReader();
                reader.Read();
                MessageBox.Show("Done!");
                connect.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

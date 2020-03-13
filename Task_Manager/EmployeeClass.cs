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
    class EmployeeClass
    {
        public int id;
        public string name;
        public string gender;
        public string password;
        public string address;
        public string phone;
        public string mail;
        public DateTime join_date;
        public string department;
        public string rank;
        public int admin_id;
        public int manager_id;
        public int salary;
        public int hours;
        public bool login(string user_name, string pass,ref EmployeeClass employee)
        {
            SqlConnection connect = new SqlConnection("Data Source=DESKTOP-T7ORQ8E\\SQLEXPRESS;Initial Catalog=ISPROJECT1;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select * from fn_login_employee('" + user_name + "','" + pass + "')", connect);
            try
            {
                connect.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                
                while (reader.Read())
                {
                    employee.id = (int)reader["employee_id"];
                    employee.name = user_name;
                    employee.password = pass;
                   // employee.department = (string)reader["employee_department"];
                    employee.gender = (string)reader["employee_gender"];
                    employee.phone = (string)reader["employee_phone"];
                    employee.address = (string)reader["employee_address"];
                    employee.mail = (string)reader["employee_mail"];
                    employee.admin_id = (int)reader["admin_id"];
                    employee.hours = (int)reader["hours"];
                    employee.salary = (int)reader["salary_per_hour"];
                    employee.rank = (string)reader["employee_rank"];
                    if (employee.rank == "employee")
                        employee.manager_id = (int)reader["manager_id"];
                    employee.join_date = (DateTime)reader["employee_join_date"];

                reader.Close();
                connect.Close();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
            return false;
        }
    }
}

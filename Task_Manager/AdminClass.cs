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
    class AdminClass
    {
        public string connectstr = "Data Source=DESKTOP-T7ORQ8E\\SQLEXPRESS;Initial Catalog=ISPROJECT1;Integrated Security=True";
        public int id;
        public string username;
        public string password;
        public bool loginadmin(string user_name, string pass, ref AdminClass admin)
        {
            SqlConnection connect = new SqlConnection(connectstr);

            SqlCommand cmd = new SqlCommand("select * from fn_login_admin('" + user_name + "','" + pass + "')", connect);
            try
            {
                connect.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                // cmd.CommandType = CommandType.TableDirect;
                while (reader.Read())
                {
                    admin.id = (int)reader["id_admin"];
                    admin.username = user_name;
                    admin.password = pass;

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
        public void projectview(ref List<ProjectClass> list)
        {
            //List<ProjectClass> list = new List<ProjectClass>();
            SqlConnection connect = new SqlConnection("Data Source=DESKTOP-T7ORQ8E\\SQLEXPRESS;Initial Catalog=ISPROJECT1;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select * from project", connect);
            try
            {
                connect.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ProjectClass pro = new ProjectClass();
                    pro.id = (int)reader["project_id"];
                    pro.name = (string)reader["project_name"];
                    pro.description = (string)reader["project_description"];
                    pro.start_time = reader.GetDateTime(3);
                    pro.end_time = reader.GetDateTime(4);
                    pro.id_client = (int)reader["project_client_id"];
                    pro.status = (string)reader["project_status"];
              
                    pro.id_manger = (int)reader["manger_id"];
                    list.Add(pro);


                }
                reader.Close();


                for (int i = 0; i < list.Count; i++)
                {
                  SqlCommand  cmd2 = new SqlCommand("select employee_name from employee where employee_id='" + list[i].id_manger + "'", connect);
                    reader = cmd2.ExecuteReader();
                    while (reader.Read())
                    {
                        list[i].manger_name = (string)reader["employee_name"];
                    }
                reader.Close();
                }
                connect.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public void addmanager(EmployeeClass newmanager)

        {
            SqlConnection connect = new SqlConnection(connectstr);
            SqlCommand cmd = new SqlCommand("execute insert_employee '" + newmanager.name + "','" + newmanager.gender + "','" + newmanager.password + "','" + newmanager.address + "','" + newmanager.phone + "','" + newmanager.mail + "','" + newmanager.join_date + "','" + newmanager.rank + "','" + newmanager.admin_id + "','" + 1 + "','" + newmanager.salary + "','" + newmanager.hours + "'", connect);
            try
            {
                connect.Open();
                cmd.ExecuteNonQuery();
                connect.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void addproject(ProjectClass pro) {
            SqlConnection connect = new SqlConnection(connectstr);
            SqlCommand cmd = new SqlCommand("select * from client where client_name='"+pro.clinet_name+"'",connect);
            try
            {
                connect.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                try
                {
                    while (reader.Read())
                    {
                        pro.id_client = (int)reader["client_id"]; 
                    }
                    reader.Close();
                    
                    connect.Close();
                    connect.Open();
                    cmd = new SqlCommand("execute insert_project '"+pro.name+"','"+pro.description+ "','" + pro.start_time + "','" + pro.end_time + "','" + pro.id_client + "','" + pro.status + "','" + pro.id_manger + "'", connect);
                    cmd.ExecuteNonQuery();
                    reader.Close();
                    connect.Close();
                }
                catch (Exception ex)
                {
                   SqlCommand cmd2 = new SqlCommand("execute insert_client '" + pro.clinet_name + "','" + pro.client_phone + "','" + pro.client_mail + "'", connect);
                    cmd2.ExecuteNonQuery();
                    SqlCommand cmd3 = new SqlCommand("select * from client where client_name='" + pro.clinet_name + "'", connect);
                    reader = cmd3.ExecuteReader();
                    
                  
                        while (reader.Read())
                        {
                            pro.id_client = (int)reader["client_id"];
                        }
                        reader.Close();
                        SqlCommand  cmd4 = new SqlCommand("execute insert_project '" + pro.name + "','" + pro.description + "','" + pro.start_time + "','" + pro.end_time + "','" + pro.id_client + "','" + pro.status + "','" + pro.id_manger + "'", connect);
                        cmd4.ExecuteNonQuery();
                        connect.Close();
                    }

                }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            }
        public List<EmployeeClass>viewmanager()
        {
            List<EmployeeClass> emplist = new List<EmployeeClass>();
            SqlConnection connect = new SqlConnection(connectstr);
            SqlCommand cmd = new SqlCommand("select * from employee", connect);
            try
            {
                connect.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read()){
                    EmployeeClass emp = new EmployeeClass();
                    emp.id = (int)reader["employee_id"];
                    emp.name =(string) reader["employee_name"];
                    emp.gender = (string)reader["employee_gender"];
                    emp.password = (string)reader["employee_password"];
                    emp.address = (string)reader["employee_address"];
                    emp.phone = (string)reader["employee_phone"];
                    emp.mail = (string)reader["employee_mail"];
                    emp.join_date = reader.GetDateTime(7);
                    emp.rank = (string)reader["employee_rank"];
                    emp.admin_id = (int)reader["admin_id"];
                    try
                    {
                        emp.manager_id = (int)reader["manager_id"];
                    }
                    catch(Exception ex)
                    {

                    }
                    emp.salary = (int)reader["salary_per_hour"];
                    emp.hours = (int)reader["hours"];
                    emplist.Add(emp);

                }
                reader.Close();
                connect.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return emplist;

        }

            }
       

        }
       
        

        
    


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
        public string connectstr = "Data Source=LAPTOP-MP5TT4VU\\SQLEXPRESS;Initial Catalog=ISPROJECT1;Integrated Security=True";
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
            SqlConnection connect = new SqlConnection("Data Source=LAPTOP-MP5TT4VU\\SQLEXPRESS;Initial Catalog=ISPROJECT1;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select * from project inner join client on project.project_client_id = client.client_id inner join employee on project.manger_id=employee.employee_id", connect);
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
                    pro.clinet_name = (string)reader["client_name"];
                    pro.client_phone = (string)reader["client_phone"];
                    pro.client_mail = (string)reader["client_mail"];
                    pro.manger_name = (string)reader["employee_name"];

                    list.Add(pro);


                }
                reader.Close();

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
        public void addproject(ProjectClass pro)
        {
            SqlConnection connect = new SqlConnection(connectstr);
            SqlCommand cmd = new SqlCommand("select * from client where client_name='" + pro.clinet_name + "'", connect);
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
                    cmd = new SqlCommand("execute insert_project '" + pro.name + "','" + pro.description + "','" + pro.start_time + "','" + pro.end_time + "','" + pro.id_client + "','" + pro.status + "','" + pro.id_manger + "'", connect);
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
                    SqlCommand cmd4 = new SqlCommand("execute insert_project '" + pro.name + "','" + pro.description + "','" + pro.start_time + "','" + pro.end_time + "','" + pro.id_client + "','" + pro.status + "','" + pro.id_manger + "'", connect);
                    cmd4.ExecuteNonQuery();
                    connect.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public List<EmployeeClass> viewmanager()
        {
            List<EmployeeClass> emplist = new List<EmployeeClass>();
            SqlConnection connect = new SqlConnection(connectstr);
            SqlCommand cmd = new SqlCommand("select * from employee", connect);
            try
            {
                connect.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    EmployeeClass emp = new EmployeeClass();
                    emp.id = (int)reader["employee_id"];
                    emp.name = (string)reader["employee_name"];
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
                    catch (Exception ex)
                    {

                    }
                    emp.salary = (int)reader["salary_per_hour"];
                    emp.hours = (int)reader["hours"];
                    emplist.Add(emp);

                }
                reader.Close();
                connect.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return emplist;

        }
        public void editproject(ProjectClass pro)
        {
            SqlConnection connect = new SqlConnection(connectstr);
            SqlCommand cmd = new SqlCommand("execute edit_project '" + pro.id + "','" + pro.name + "','" + pro.description + "','" + pro.start_time + "','" + pro.end_time + "','" + pro.status + "'", connect);
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
        public void delete_project(int id)
        {
            SqlConnection connect = new SqlConnection(connectstr);
            SqlCommand cmd = new SqlCommand("execute delete_project '" + id + "'", connect);
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
        public void delete_employee(int id)
        {
            SqlConnection connect = new SqlConnection(connectstr);
            SqlCommand cmd = new SqlCommand("execute delete_employee '" + id + "'", connect);
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
        public void edit_employee(EmployeeClass employee)
        {
            SqlConnection connect = new SqlConnection(connectstr);
            SqlCommand cmd = new SqlCommand("execute edit_employee '" + employee.id + "','" + employee.name + "','" + employee.gender + "','" + employee.password + "','" + employee.address + "','" + employee.phone + "','" + employee.mail + "','" + employee.join_date + "','" + employee.rank + "','" + employee.manager_id + "','" + employee.salary + "','" + employee.hours + "'", connect);
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
        public void showtask(ref List<TaskClass>tasklist,int idproject)
        {
            SqlConnection connect = new SqlConnection(connectstr);
            SqlCommand cmd = new SqlCommand("select * from task inner join project on task.task_project_id=project.project_id inner join employee on task.task_employee_id=employee.employee_id where project.project_id='" + idproject+"'",connect);
            try
            {
                connect.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    TaskClass task = new TaskClass();

                    task.id =(int) reader["task_id"];
                    task.name = (string)reader["task_name"];
                    task.description = (string)reader["task_description"];
                    task.start_time = reader.GetDateTime(3);
                    task.end_time = reader.GetDateTime(4);
                    task.id_project = (int)reader["task_project_id"];
                    task.id_employee = (int)reader["task_employee_id"];
                    task.status = (string)reader["task_status"];
                    task.project_name = (string)reader["project_name"];
                    task.employee_name = (string)reader["employee_name"];
                    tasklist.Add(task);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

    }


}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Task_Manager;

namespace Task_Manager
{
   public class EmployeeClass
    {
        public string connectstr = "Data Source=LAPTOP-MP5TT4VU\\SQLEXPRESS;Initial Catalog=ISPROJECT1;Integrated Security=True";
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
        public static List<ProjectClass> list=new List<ProjectClass>();
        public bool login(string user_name, string pass,string rank,ref EmployeeClass employee)
        {
            SqlConnection connect = new SqlConnection("Data Source=LAPTOP-MP5TT4VU\\SQLEXPRESS;Initial Catalog=ISPROJECT1;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select * from fn_login_employee('" + user_name + "','" + pass + "','"+rank+ "')", connect);
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
                    if (employee.rank == "Employee")
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
        public void displayprojects(ref List<ProjectClass>list,int id)
        {
            SqlConnection connect = new SqlConnection(connectstr);
            SqlCommand cmd = new SqlCommand("select * from project inner join client on project.project_client_id = client.client_id inner join employee on project.manger_id=employee.employee_id where project.manger_id='"+id+"' ", connect);
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
        public List<EmployeeClass> viewemployee(int id)
        {
            List<EmployeeClass> emplist = new List<EmployeeClass>();
            SqlConnection connect = new SqlConnection(connectstr);
            SqlCommand cmd = new SqlCommand("select * from employee where manager_id='"+id+"'", connect);
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
                    emp.manager_id = id;                 
                    
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

        public void displaytasks(ref List<TaskClass> list, int id)
        {
            SqlConnection connect = new SqlConnection(connectstr);
            SqlCommand cmd = new SqlCommand("select * from task inner join employee on task.task_employee_id = employee.employee_id inner join project on project.project_id=task.task_project_id where task.task_employee_id='" + id + "' ", connect);
            try
            {
                connect.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    TaskClass task = new TaskClass();
                    task.id = (int)reader["task_id"];
                    task.name = (string)reader["task_name"];
                    task.description = (string)reader["task_description"];
                    task.start_time = reader.GetDateTime(3);
                    task.end_time = reader.GetDateTime(4);
                    task.id_project = (int)reader["task_project_id"];
                    task.id_employee = (int)reader["task_employee_id"];
                    try
                    {
                        task.comment = (string)reader["task_comment"];
                    }
                    catch (Exception ex)
                    {

                    }
                    task.status = (string)reader["task_status"];
                    if (task.status == "Waitting")
                        task.assign_employee = (int)reader["assign_employee"];
                    task.employee_name = (string)reader["employee_name"];
                    task.project_name = (string)reader["project_name"];
                    list.Add(task);

                }
                reader.Close();

                connect.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void display_assigntasks(ref List<TaskClass> list, int id)
        {
            SqlConnection connect = new SqlConnection(connectstr);
            SqlCommand cmd = new SqlCommand("select * from task inner join employee on task.task_employee_id = employee.employee_id inner join project on project.project_id=task.task_project_id where task.assign_employee='" + id + "' ", connect);
            try
            {
                connect.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    TaskClass task = new TaskClass();
                    task.id = (int)reader["task_id"];
                    task.name = (string)reader["task_name"];
                    task.description = (string)reader["task_description"];
                    task.start_time = reader.GetDateTime(3);
                    task.end_time = reader.GetDateTime(4);
                    task.id_project = (int)reader["task_project_id"];
                    task.id_employee = (int)reader["task_employee_id"];
                    task.comment = (string)reader["task_comment"];
                    task.status = (string)reader["task_status"];
                    if (task.status == "Waitting")
                        task.assign_employee = (int)reader["assign_employee"];
                    task.employee_name = (string)reader["employee_name"];
                    task.project_name = (string)reader["project_name"];
                    list.Add(task);

                }
                reader.Close();

                connect.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public List<EmployeeClass> displayemployee(int id,int manager_id)
        {
            List<EmployeeClass> emplist = new List<EmployeeClass>();
            SqlConnection connect = new SqlConnection(connectstr);
            SqlCommand cmd = new SqlCommand("select * from fn_view_employee_employee('" + manager_id + "','" + id + "')", connect);
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
                    emp.manager_id = id;
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

        public void edittask(TaskClass task)
        {
            SqlConnection connect = new SqlConnection(connectstr);
            SqlCommand cmd = new SqlCommand("execute edit_task '" + task.id + "','" + task.name + "','" + task.description + "','" + task.start_time + "','" + task.end_time + "','" + task.id_project + "','" + task.id_employee + "','" + task.status + "','" + task.assign_employee + "','" + task.comment + "'", connect);
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

        public void finishproject(int id)
        {
            AdminClass adm = new AdminClass();
            ProjectClass pro = new ProjectClass();
            adm.projectview(ref list);
            for(int i=0;i<list.Count;i++)
            {
                if(list[i].id==id)
                {
                    pro = list[i];
                    break;
                }
            }
            SqlConnection connect = new SqlConnection(connectstr);
            SqlCommand cmd = new SqlCommand("select dbo.check_finish('" +pro.id +"')", connect);
            try
            {
                connect.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    pro.status = reader.GetString(0);
                }
                reader.Close();
                SqlCommand cmd2 = new SqlCommand("execute edit_project '" + pro.id + "', '" + pro.name + "', '" + pro.description + "', '" + pro.start_time + "', '" + pro.end_time + "', '" + pro.status + "'", connect);
                cmd2.ExecuteNonQuery();
                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void calculatehour(TaskClass task,EmployeeClass employee)
        {
            double time = Convert.ToDouble((5 *Math.Abs((task.end_time.Day - task.start_time.Day) + 1)) / 7);
            employee.hours += 8* Convert.ToInt32(Math.Ceiling(time));
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



        public void AssignTask(TaskClass emptask)
        {
            SqlConnection connect = new SqlConnection(connectstr);
            SqlCommand cmd = new SqlCommand("select dbo.start_task('"+emptask.start_time+"','"+emptask.status+"')",connect);
            try
            {
                connect.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    emptask.status = reader.GetString(0);
                }
                reader.Close();
                SqlCommand cmd2 = new SqlCommand("execute insert_task '"+emptask.name+"','"+emptask.description+"','"+emptask.start_time+"','"+emptask.end_time+"','"+emptask.id_project+"','"+emptask.id_employee+"','"+emptask.status+"','"+emptask.assign_employee+"','"+emptask.comment+"'",connect);
                cmd2.ExecuteNonQuery();
                connect.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

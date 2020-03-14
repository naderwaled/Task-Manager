using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Manager
{
   public class TaskClass
    {
        public int id;
        public string name;
        public string description;
        public DateTime start_time;
        public DateTime end_time;
        public string status;
        public int id_project;
        public int id_employee;
        public int assign_employee=0;
        public string comment="";
        public string employee_name;
        public string project_name;
    }
}

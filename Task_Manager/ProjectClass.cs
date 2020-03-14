using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Manager
{
  public  class ProjectClass
    {
        public int id;
        public string name;
        public string description;
        public DateTime start_time;
        public DateTime end_time;
        public string status;
        public int priority;
        public int id_client;
        
        public string clinet_name;
        public string client_phone;
        public string client_mail;
        public int id_manger;
        public string manger_name;
    }
}

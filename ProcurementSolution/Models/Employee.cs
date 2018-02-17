using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcurementSolution.Models
{
    class Employee
    {
        public string emp_name { get; set; }
        public string email { get; set; }
        public string phone_number { get; set; }
        public DateTime reg_date { get; set; }

        public Employee()
        {
            this.emp_name = "";
            this.email = "";
            this.phone_number = "";
            this.reg_date = DateTime.Now;
        }
        
        public Employee(string name, string email, string phone_number)
        {
            this.emp_name = name;
            this.email = email;
            this.phone_number = phone_number;
            this.reg_date = DateTime.Now;
        }


    }
}

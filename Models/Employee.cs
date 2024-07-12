using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConexionBD.Models
{
    using System;

    public class Employee
    {
        int employee_id;
        string first_name;
        string last_name;
        string email;
        string? phone_number;
        DateTime hire_date;
        int job_id;
        decimal salary;
        int? manager_id;
        int? deparment_id;
        public Employee()
        {

        }

        public Employee(int employee_id, string first_name, string last_name, string email,
            string? phone_number, DateTime hire_date, int job_id, decimal salary, int? manager_id, int? deparment_id)
        {
            this.employee_id = employee_id;
            this.first_name = first_name;
            this.last_name = last_name;
            this.email = email;
            this.phone_number = phone_number;
            this.hire_date = hire_date;
            this.job_id = job_id;
            this.salary = salary;
            this.manager_id = manager_id;
            this.deparment_id = deparment_id;
        }

        public int Employee_id { get => employee_id; set => employee_id = value; }
        public string First_name { get => first_name; set => first_name = value; }
        public string Last_name { get => last_name; set => last_name = value; }
        public string Email { get => email; set => email = value; }
        public string? Phone_number { get => phone_number; set => phone_number = value; }
        public DateTime Hire_date { get => hire_date; set => hire_date = value; }
        public int Job_id { get => job_id; set => job_id = value; }
        public decimal Salary { get => salary; set => salary = value; }
        public int? Manager_id { get => manager_id; set => manager_id = value; }
        public int? Deparment_id { get => deparment_id; set => deparment_id = value; }

    }
}

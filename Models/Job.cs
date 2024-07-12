using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConexionBD.Models
{
    public class Job
    {
        private int job_id;
        private string job_title;
        private decimal min_salary;
        private decimal max_salary;
        public Job()
        {

        }
        public int Job_id { get => job_id; set => job_id = value; }
        public string Job_title { get => job_title; set => job_title = value; }
        public decimal Min_salary { get => min_salary; set => min_salary = value; }
        public decimal Max_salary { get => max_salary; set => max_salary = value; }

        public Job(int job_id, string job_title, decimal min_salary, decimal max_salary)
        {
            this.job_id = job_id;
            this.job_title = job_title;
            this.min_salary = min_salary;
            this.max_salary = max_salary;

        }
    }
}

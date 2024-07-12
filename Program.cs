using ConexionBD.DALs;
using ConexionBD.Models;

namespace ConexionBD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome");
            Console.WriteLine("=====================================");
            Console.WriteLine("");

            EmployeeDAL getEmployees = new EmployeeDAL();
            JobDAL getJob = new JobDAL();
            List<Employee> employees = new List<Employee>();
            employees = getEmployees.GetEmployee();

            List<Job>? jobs = new List<Job>();
            jobs = getJob.GetJob();

            foreach (Job job  in jobs)
            {
                Console.WriteLine("Job: {0}", job.Job_title.ToString());
            }

        }
    }
}

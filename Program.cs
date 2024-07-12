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

            DependentDAL getDependent = new DependentDAL();

            List<Employee> employees = new List<Employee>();
            employees = getEmployees.GetEmployee();

            List<Dependent>? dependents= new List<Dependent>();
            dependents = getDependent.GetDependent();

            foreach (Dependent dependent in dependents)
            {
                Console.WriteLine("Dependent: {0}", dependent.First_name.ToString());
            }

        }
    }
}

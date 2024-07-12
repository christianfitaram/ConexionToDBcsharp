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
            List<Employee> employees = new List<Employee>();
            employees = getEmployees.GetEmployee();

           
            foreach (Employee employee in employees)
            {
                Console.WriteLine("Empleado: {0}, {1}", employee.First_name, employee.Last_name);
            }

        }
    }
}

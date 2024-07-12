using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConexionBD.Models
{
    public class Dependent
    {
        int dependent_id;
        string first_name;
        string last_name;
        string relationship;
        int employee_id;
        public Dependent()
        { 

        }

        public int Dependent_id { get => dependent_id; set => dependent_id = value; }
        public string First_name { get => first_name; set => first_name = value; }
        public string Last_name { get => last_name; set => last_name = value; }
        public string Relationship { get => relationship; set => relationship = value; }
        public int Employee_id { get => employee_id; set => employee_id = value; }

        public Dependent(int dependent_id, string first_name, string last_name, string relationship, int employee_id)
        {
            this.dependent_id = dependent_id;
            this.first_name = first_name;
            this.last_name = last_name; 
            this.relationship = relationship;  
            this.employee_id = employee_id;
        } 
    }
}

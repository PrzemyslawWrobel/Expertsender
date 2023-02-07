using ExpertSender.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpertSender.Domain.Entities
{
    public class Department : AuditableEntity    
    {
        public Department()
        {
            //Employees= new List<Employee>();
        } 

        public string DepartmentName { get; set; }
        
        // Relations 1 : N 
        //public List<Employee> Employees { get; set; }
    }
}

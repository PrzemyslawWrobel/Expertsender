 using ExpertSender.Domain.Common;
using ExpertSender.Domain.Enums;
using ExpertSender.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ExpertSender.Domain.Entities
{
    public class Employee : AuditableEntity
    {
        public Employee()
        {
            Addresses = new List<Address>();
        }
        //public int Id { get; set; }

        /// <summary>
        /// Value object Employee FirstName , LastName
        /// </summary>
        public EmployeeName EmployeeName { get; set; }

        public string Email { get; set; }
        public DateTime DateOfBrith { get; set; }
        public Gender Gender { get; set; }
        //public Department Department { get; set; }
        //public int DepartmentId { get; set; }//Relations 1 : N 

        // Relation 1 : N One Employee to many Adresses
        public List<Address> Addresses { get; set; }

    }
}

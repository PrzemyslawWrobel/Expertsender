using ExpertSender.Domain.Common;
using ExpertSender.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
        public int Id { get; set; }

        /// <summary>
        /// Dane osoby do kontaktów
        /// </summary>
        public EmployeeName EmployeeName { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }


        // Relacja 1 : N relacja jeden Customer wiele adresów
        public List<Address> Addresses { get; set; }
    }
}

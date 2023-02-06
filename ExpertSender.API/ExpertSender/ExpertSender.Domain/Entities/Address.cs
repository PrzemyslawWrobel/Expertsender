using ExpertSender.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpertSender.Domain.Entities
{
    public class Address : AuditableEntity
    {
        public Address()
        {

        }

        public string AddressType { get; set; }
        public string Street { get; set; }
        public string BuildingNumber { get; set; }
        public string FlatNumber { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

        /*-- Relations --*/

        //Relation 1 : N  to Employee
        public int EmployeeId { get; set; } 
        public Employee Employee { get; set; }

    }
}

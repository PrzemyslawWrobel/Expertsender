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
        public int Id { get; set; }

        /// <summary>
        /// Adress type - home, correspondence.
        /// </summary>
        public string AddressType { get; set; }

        /// <summary>
        /// Name of street.
        /// </summary>
        public string Street { get; set; }

        /// <summary>
        /// Naumber of building, block, house.
        /// </summary>
        public string BuildingNumber { get; set; }

        /// <summary>
        /// Flat number.
        /// </summary>
        public string FlatNumber { get; set; }

        /// <summary>
        /// Zipp code.
        /// </summary>
        public string ZipCode { get; set; }

        /// <summary>
        /// Name of city, village.
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// Name of country.
        /// </summary>
        public string Country { get; set; }

        /*-- Relations --*/

        //Relation 1 : N  to Employee
        public int? EmployeeId { get; set; } 
        public Employee Employee { get; set; }

    }
}

using ExpertSender.Domain.Enums;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpertSender.Application.Employees.Commands.CreateEmployee
{
    public class CreateEmployeeCommand : IRequest<int>
    {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBrith { get; set; }
        public Gender Gender { get; set; }

        public string DepartmentName { get; set; }

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


    }
}

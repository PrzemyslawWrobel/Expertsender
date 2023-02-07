using ExpertSender.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ExpertSender.Persistance.Seed
{
    public static class Seed
    {
        public static void SeedData(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().OwnsOne(c => c.EmployeeName).HasData(new
            {
                Id = 1,
                DepartmentId = 1,
                Email = "j.fasola@gmail.com",
                DateOfBrith = new DateTime(1979, 12, 01),
                Gender = Domain.Enums.Gender.Male,
                EmployeeNameFirstName = "Jaś",
                SecondName = String.Empty,
                LastName = "Fasola"
            });

            modelBuilder.Entity<Employee>().OwnsOne(c => c.EmployeeName).HasData(new
            {
                Id = 2,
                DepartmentId = 2,
                Email = "k.donald@gmail.com",
                DateOfBrith = new DateTime(1985, 1, 01),
                Gender = Domain.Enums.Gender.Male,
                FirstName = "Kaczor",
                SecondName = String.Empty,
                LastName = "Donald"
            });

            modelBuilder.Entity<Employee>().OwnsOne(c => c.EmployeeName).HasData(new
            {
                Id = 3,
                DepartmentId = 3,
                Email = "m.minigmail.com",
                DateOfBrith = new DateTime(1986, 12, 27),
                Gender = Domain.Enums.Gender.Female,
                FirstName = "Myszka",
                SecondName = String.Empty,
                LastName = "Mini"
            });

            modelBuilder.Entity<Address>().HasData(new Address()
            {
                Id = 1,
                EmployeeId = 1,
                AddressType = "Firmowy",
                Street = "Jana Pawła II",
                BuildingNumber = "179",
                FlatNumber = "2B",
                ZipCode = "43-300",
                City = "Kraków",
                Country = "Poland"
            });
            modelBuilder.Entity<Address>().HasData(new Address()
            {
                Id = 2,
                EmployeeId = 2,
                AddressType = "Firmowy",
                Street = "Jana Pawła II",
                BuildingNumber = "179",
                FlatNumber = "2B",
                ZipCode = "43-300",
                City = "Kraków",
                Country = "Poland"
            });

            modelBuilder.Entity<Address>().HasData(new Address()
            {
                Id = 3,
                EmployeeId = 3,
                AddressType = "Firmowy",
                Street = "Jana Pawła II",
                BuildingNumber = "179",
                FlatNumber = "2B",
                ZipCode = "43-300",
                City = "Kraków",
                Country = "Poland"
            });

            modelBuilder.Entity<Department>().HasData(new Department()
            {
                Id = 1,
                DepartmentName = "R&D"
            });

            modelBuilder.Entity<Department>().HasData(new Department()
            {
                Id = 2,
                DepartmentName = ".net dev"
            });
            
            modelBuilder.Entity<Department>().HasData(new Department()
            {
                Id = 3,
                DepartmentName = "Data Base"
            });

            
        }
    }
}

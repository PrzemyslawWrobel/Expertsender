using ExpertSender.Application.Common.Interfaces;
using ExpertSender.Domain.Common;
using MediatR;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using ExpertSender.Domain.Entities;
using ExpertSender.Persistance.Seed;

namespace ExpertSender.Persistance
{
    public class ExpertSenderDbContext : DbContext, IExpertSenderDbContext
    {
        private readonly IDateTime _dateTime;
        //private readonly ICurrentUserService _userService;
        public ExpertSenderDbContext(DbContextOptions<ExpertSenderDbContext> options, IDateTime dateTime ) : base(options) //TODO ,ICurrentUserService userService
        {
            _dateTime = dateTime;
            //_userService = userService;
        }

        public ExpertSenderDbContext(DbContextOptions<ExpertSenderDbContext> options) : base(options)
        {
        }

        public DbSet<Address> Addresses { get; set; }
        public DbSet<Employee> Employees { get; set; }
       

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.SeedData();
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            foreach (var entry in ChangeTracker.Entries<AuditableEntity>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.CreatedBy = "User";//_userService.Username;
                        entry.Entity.Created = _dateTime.Now;
                        entry.Entity.StatusId = 1;
                        break;
                    case EntityState.Modified:
                        entry.Entity.ModifiedBy = "User"; // _userService.Username;
                        entry.Entity.Modified = _dateTime.Now;
                        break;
                    case EntityState.Deleted:
                        entry.Entity.ModifiedBy = "User"; // _userService.Username;
                        entry.Entity.Modified = _dateTime.Now;
                        entry.Entity.Inactivated = _dateTime.Now;
                        entry.Entity.InactivatedBy = "User"; // _userService.Username;
                        entry.Entity.StatusId = 0;
                        entry.State = EntityState.Modified;
                        break;
                }
            }
            return base.SaveChangesAsync(cancellationToken);
        }
    }
}


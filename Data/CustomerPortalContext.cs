
#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CustomerPortal.Models;

    public class CustomerPortalContext : DbContext
    {
        public CustomerPortalContext (DbContextOptions<CustomerPortalContext> options)
            : base(options)
        {
        }

        public DbSet<CustomerPortal.Models.Customer> Customer { get; set; }

        public DbSet<CustomerPortal.Models.Battery> Battery { get; set; }

        public DbSet<CustomerPortal.Models.Building> Building { get; set; }

        public DbSet<CustomerPortal.Models.Column> Column { get; set; }

        public DbSet<CustomerPortal.Models.Elevator> Elevator { get; set; }

        public DbSet<CustomerPortal.Models.Employee> Employee { get; set; }
    }
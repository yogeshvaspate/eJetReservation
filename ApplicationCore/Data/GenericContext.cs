using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using ApplicationCore.Entities;

namespace ApplicationCore.Data
{
    public class GenericContext : DbContext
    {
        public GenericContext(DbContextOptions options) : base(options)
        { }

        public DbSet<Customer> Customers { get; set; }
    }
}

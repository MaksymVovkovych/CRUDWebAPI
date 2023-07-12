﻿using CEUDWebAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CRUDWebAPI.Infrastructure.Persistence
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}
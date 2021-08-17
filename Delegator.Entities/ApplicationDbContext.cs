using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Delegator.Entities
{
    public class ApplicationDbContext : DbContext {
        public DbSet<User> Users { get; set;}
        
        protected override void OnConfiguring(DbContextOptionsBuilder options) { }
    }
}

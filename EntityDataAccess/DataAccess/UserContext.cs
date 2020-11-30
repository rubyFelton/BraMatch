using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace EntityDataAccess.DataAccess
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions options) : base(options) { }
        public DbSet<Models.User> Users { get; set; }
        public DbSet<Models.Bra> Bras { get; set; }
        public DbSet<Models.BraSize> BraSizes { get; set; }
        public DbSet<Models.BraType> BraTypes { get; set; }

    }
}

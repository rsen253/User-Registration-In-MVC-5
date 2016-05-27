using CascadeDropdown.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CascadeDropdown.DBContext
{
    public class DatabaseContext : DbContext
    {
        public DbSet<User> User { get; set; }
        public DbSet<State> State { get; set; }
        public DbSet<Country> Country { get; set; }
        public DbSet<ProfilePic> ProfilePic { get; set; }
    }
}
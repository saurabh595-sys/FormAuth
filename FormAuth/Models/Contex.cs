using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace FormAuth.Models
{
    public class Contex : DbContext
    {
        public DbSet<Product> Product { get; set; }
        public DbSet<Catagory> Category { get; set; }
        public DbSet<UserDetail> UserDetails { get; set; }
        public DbSet<Roles> Roles { get; set; }
    }
}
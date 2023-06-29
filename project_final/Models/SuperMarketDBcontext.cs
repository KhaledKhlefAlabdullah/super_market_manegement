using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_final.Models
{
    internal class SuperMarketDBcontext:DbContext
    {
        public DbSet<User> users { get; set; }
        public DbSet<Role> roles { get; set; }
        public DbSet<UserRoles> usersRoles { get; set; }
        public DbSet<Store> stores { get; set; }
        public DbSet<Sales> sales { get; set; }
        public DbSet<Bill> Bill { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Data Source=khaled\SQLEXPRESS;Initial Catalog=super_market;Integrated Security=True;TrustServerCertificate=True");
        }

    }
}

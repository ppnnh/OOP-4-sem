using Lab_11.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_11.Context
{
    public class MyDb : DbContext
    {
        public MyDb() : base("DBConnection") { }

        public DbSet<Worker> Worker { get; set; }
        public DbSet<Plane> Plane { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP_LAB_12.Classes;

namespace OOP_LAB_12.Context
{
    public class Context : DbContext
    {
        public Context() : base("SmartphoneDataBase") { }
        public DbSet<Smartphone> Smartphones { get; set; }
        public DbSet<Provider> Providers { get; set; }
    }
}

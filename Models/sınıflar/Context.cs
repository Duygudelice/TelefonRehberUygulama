using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace telefonrehberuygulaması.Models.sınıflar
{
    public class Context : DbContext
    {
        public DbSet<Rehber> Rehbers { get; set; }
    }
}
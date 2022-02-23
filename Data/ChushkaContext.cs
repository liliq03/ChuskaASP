using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.CHUSHKA12d.Data
{
    public class ChushkaContext:DbContext
    {//konstruktor
        public ChushkaContext()
        {

        }
        public ChushkaContext(DbContextOptions<ChushkaContext> options) : base(options)
        {

        }

        //tablici
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
    }
}

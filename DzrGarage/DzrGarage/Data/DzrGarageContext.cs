using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DzrGarage.Models;
using Microsoft.EntityFrameworkCore;

namespace DzrGarage.Data
{
    public class DzrGarageContext : DbContext
    {
        public DzrGarageContext (DbContextOptions<DzrGarageContext> options)
            : base(options)
        {
        }

        //public DbSet<User> Users { get; set; }
        public DbSet<Box> Boxes { get; set; }
        //public DbSet<> ArticlesLog { get; set; }
    }
}

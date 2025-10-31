using Microsoft.EntityFrameworkCore;
using mvvm_structure.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvvm_structure.ApplicationDbContext
{
    class AppDbContext : DbContext
    {
        public DbSet<MainModel> mainModels { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    }
}


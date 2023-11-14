using EntityFrameWorkCore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWorkCore.DAL
{
    internal class AppDbContext:DbContext
    {
      
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                base.OnConfiguring(optionsBuilder);
                optionsBuilder.UseSqlServer("server=DESKTOP-Q6UFVMD;database=task_framework; Trusted_connection=true;Integrated security=true;Encrypt=false");
            }

        public DbSet<Student>Students { get; set; }
        public  DbSet<Group> Groups { get; set; }
    }
}

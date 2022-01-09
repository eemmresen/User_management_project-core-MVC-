using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AvansasProject.Models
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        {
            optionsBuilder.UseSqlServer("Server =.; Database = Avansasdb; uid = emresen; pwd = 1234");
            ///  base.OnConfiguring(optionsBuilder);AvansasMig

        }
        public DbSet<Users> Userlar { get; set; }
    }
}

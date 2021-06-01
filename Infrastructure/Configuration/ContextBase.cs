using Entities.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Configuration
{
    class ContextBase : DbContext
    {
        public ContextBase(DbContextOptions<ContextBase> options) : base(options)
        {

        }

        public DbSet<Produto> Produto { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(GetStringConectionConfig());
                base.OnConfiguring(optionsBuilder);
            }
        }

        private string GetStringConectionConfig()
        {
            string strCon = "Data Source = DESKTOP-B4PVLR9\\SQLEXPRESS; Initial Catalog = EcommerceDDD; Integrated Security = True";
            return strCon;
        }


    }
}

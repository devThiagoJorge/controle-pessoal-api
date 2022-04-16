using controle_pessoal_api.Data.ModelsConfigurations;
using controle_pessoal_api.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace controle_pessoal_api.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) 
            : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<PaymentType> PaymentTypes { get; set; }
        public DbSet<Purchase> Purchases { get; set; }

      
        protected override void OnModelCreating(ModelBuilder options)
        {
            options.ApplyConfiguration(new CategoryConfiguration());
            options.ApplyConfiguration(new PaymentTypeConfiguration());
            options.ApplyConfiguration(new PurchaseConfiguration());
        }

    }
}

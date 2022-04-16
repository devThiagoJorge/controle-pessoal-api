using controle_pessoal_api.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace controle_pessoal_api.Data.ModelsConfigurations
{
    public class PurchaseConfiguration : IEntityTypeConfiguration<Purchase>
    {
        public void Configure(EntityTypeBuilder<Purchase> builder)
        {
            builder.ToTable("purchases");

            builder
                .HasKey(x => x.Id);

            builder
                .Property(x => x.Id)
                .ValueGeneratedOnAdd();

            builder
                .Property(x => x.Description)
                .HasMaxLength(280)
                .IsRequired();

            builder
                .Property(x => x.Date)
                .IsRequired();

            builder
                .Property(x => x.Price)
                .IsRequired();

            //builder.Property(x => x.Category)
            //    .HasColumnName("category_id");

            //builder.Property(x => x.PaymentType)
            //    .HasColumnName("payment_type_id");

            builder
                .HasOne(x => x.PaymentType)
                .WithMany(x => x.Purchases);

            builder
                .HasOne(x => x.Category)
                .WithMany(x => x.Purchases);

             
        }
    }
}

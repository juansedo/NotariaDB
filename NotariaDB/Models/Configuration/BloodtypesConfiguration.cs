using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NotariaDB.Seeders;
using System;
using System.Collections.Generic;
using System.Text;

namespace NotariaDB.Models.Configuration
{
    class BloodtypesConfiguration : IEntityTypeConfiguration<Bloodtypes>
    {
        public void Configure(EntityTypeBuilder<Bloodtypes> builder)
        {
            BloodtypesSeeder seeder = new BloodtypesSeeder();

            builder.HasKey(e => e.BloodtypeId)
                    .HasName("PRIMARY");

            builder.ToTable("bloodtypes");

            builder.Property(e => e.BloodtypeId).HasColumnName("bloodtype_id");

            builder.Property(e => e.Name)
                .IsRequired()
                .HasColumnName("name")
                .HasMaxLength(5);

            builder.HasData(seeder.Run());
        }
    }
}

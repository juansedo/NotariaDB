using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NotariaDB.Seeders;
using System;
using System.Collections.Generic;
using System.Text;

namespace NotariaDB.Models.Configuration
{
    class DoctypesConfiguration : IEntityTypeConfiguration<Doctypes>
    {
        public void Configure(EntityTypeBuilder<Doctypes> builder)
        {
            DoctypesSeeder seeder = new DoctypesSeeder();

            builder.HasKey(e => e.DoctypeId)
                    .HasName("PRIMARY");

            builder.ToTable("doctypes");

            builder.Property(e => e.DoctypeId).HasColumnName("doctype_id");

            builder.Property(e => e.Description)
                .IsRequired()
                .HasColumnName("description")
                .HasMaxLength(50);

            builder.HasData(seeder.Run());
        }
    }
}

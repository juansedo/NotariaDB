using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NotariaDB.Seeders;
using System;
using System.Collections.Generic;
using System.Text;

namespace NotariaDB.Models.Configuration
{
    class MatAttachesConfiguration : IEntityTypeConfiguration<MatAttaches>
    {
        public void Configure(EntityTypeBuilder<MatAttaches> builder)
        {
            MatAttachesSeeder seeder = new MatAttachesSeeder();

            builder.HasKey(e => e.AttachId)
                    .HasName("PRIMARY");

            builder.ToTable("mat_attaches");

            builder.Property(e => e.AttachId).HasColumnName("attach_id");

            builder.Property(e => e.Name)
                .IsRequired()
                .HasColumnName("name")
                .HasMaxLength(50);

            builder.HasData(seeder.Run());
        }
    }
}

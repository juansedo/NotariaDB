using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NotariaDB.Seeders;
using System;
using System.Collections.Generic;
using System.Text;

namespace NotariaDB.Models.Configuration
{
    class NacAttachesConfiguration : IEntityTypeConfiguration<NacAttaches>
    {
        public void Configure(EntityTypeBuilder<NacAttaches> builder)
        {
            NacAttachesSeeder seeder = new NacAttachesSeeder();

            builder.HasKey(e => e.AttachId)
                    .HasName("PRIMARY");

            builder.ToTable("nac_attaches");

            builder.Property(e => e.AttachId).HasColumnName("attach_id");

            builder.Property(e => e.Name)
                .IsRequired()
                .HasColumnName("name")
                .HasMaxLength(50);

            builder.HasData(seeder.Run());
        }
    }
}

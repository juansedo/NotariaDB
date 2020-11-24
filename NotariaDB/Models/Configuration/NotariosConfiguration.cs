using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NotariaDB.Seeders;
using System;
using System.Collections.Generic;
using System.Text;

namespace NotariaDB.Models.Configuration
{
    class NotariosConfiguration : IEntityTypeConfiguration<Notarios>
    {
        public void Configure(EntityTypeBuilder<Notarios> builder)
        {
            NotariosSeeder seeder = new NotariosSeeder();

            builder.HasKey(e => e.UserId)
                    .HasName("PRIMARY");

            builder.ToTable("notarios");

            builder.Property(e => e.UserId)
                .HasColumnName("user_id")
                .HasMaxLength(15);

            builder.Property(e => e.Title)
                .IsRequired()
                .HasColumnName("title")
                .HasMaxLength(50);

            builder.HasOne(d => d.User)
                .WithOne(p => p.Notarios)
                .HasForeignKey<Notarios>(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_notarios_user_id");

            builder.HasData(seeder.Run());
        }
    }
}

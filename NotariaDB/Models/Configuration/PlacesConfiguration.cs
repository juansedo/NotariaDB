using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NotariaDB.Seeders;
using System;
using System.Collections.Generic;
using System.Text;

namespace NotariaDB.Models.Configuration
{
    class PlacesConfiguration : IEntityTypeConfiguration<Places>
    {
        public void Configure(EntityTypeBuilder<Places> builder)
        {
            PlacesSeeder seeder = new PlacesSeeder();

            builder.HasKey(e => e.PlaceId)
                    .HasName("PRIMARY");

            builder.ToTable("places");

            builder.HasIndex(e => e.CityId)
                .HasName("fk_places_city_id_idx");

            builder.HasIndex(e => e.DepartmentId)
                .HasName("fk_places_department_id_idx");

            builder.Property(e => e.PlaceId).HasColumnName("place_id");

            builder.Property(e => e.CityId).HasColumnName("city_id");

            builder.Property(e => e.DepartmentId).HasColumnName("department_id");

            builder.HasOne(d => d.City)
                .WithMany(p => p.Places)
                .HasForeignKey(d => d.CityId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_places_city_id");

            builder.HasOne(d => d.Department)
                .WithMany(p => p.Places)
                .HasForeignKey(d => d.DepartmentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_places_department_id");

            builder.HasData(seeder.Run());
        }
    }
}

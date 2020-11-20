using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NotariaDB.Seeders;
using System;
using System.Collections.Generic;
using System.Text;

namespace NotariaDB.Models.Configuration
{
    class UsuariosConfiguration : IEntityTypeConfiguration<Usuarios>
    {
        public void Configure(EntityTypeBuilder<Usuarios> builder)
        {
            UsuariosSeeder seeder = new UsuariosSeeder();

            builder.ToTable("usuarios");

            builder.HasIndex(e => e.DoctypeId)
                .HasName("fk_doctypes_usuarios_idx");

            builder.Property(e => e.Id)
                .HasColumnName("id")
                .HasMaxLength(15);

            builder.Property(e => e.BirthDate)
                .HasColumnName("birth_date")
                .HasColumnType("date");

            builder.Property(e => e.DoctypeId).HasColumnName("doctype_id");

            builder.Property(e => e.ExpeditionDate)
                .HasColumnName("expedition_date")
                .HasColumnType("date");

            builder.Property(e => e.ExpeditionPlace)
                .HasColumnName("expedition_place")
                .HasMaxLength(100);

            builder.Property(e => e.Name)
                .IsRequired()
                .HasColumnName("name")
                .HasMaxLength(50);

            builder.Property(e => e.Surname)
                .IsRequired()
                .HasColumnName("surname")
                .HasMaxLength(50);

            builder.HasOne(d => d.Doctype)
                .WithMany(p => p.Usuarios)
                .HasForeignKey(d => d.DoctypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_usuarios_doctype_id");

            builder.HasData(seeder.Run());
        }
    }
}

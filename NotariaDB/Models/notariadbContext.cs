using NotariaDB.Models.Configuration;
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace NotariaDB.Models
{
    public partial class notariadbContext : DbContext
    {
        public notariadbContext()
        {
        }

        public notariadbContext(DbContextOptions<notariadbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Bloodtypes> Bloodtypes { get; set; }
        public virtual DbSet<Cities> Cities { get; set; }
        public virtual DbSet<Defunciones> Defunciones { get; set; }
        public virtual DbSet<Departments> Departments { get; set; }
        public virtual DbSet<Doctypes> Doctypes { get; set; }
        public virtual DbSet<MatAttaches> MatAttaches { get; set; }
        public virtual DbSet<Matrimonios> Matrimonios { get; set; }
        public virtual DbSet<Medicos> Medicos { get; set; }
        public virtual DbSet<NacAttaches> NacAttaches { get; set; }
        public virtual DbSet<Nacimientos> Nacimientos { get; set; }
        public virtual DbSet<Notarios> Notarios { get; set; }
        public virtual DbSet<Places> Places { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySQL("Server=localhost;Database=notariadb;Username=root;Password=");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BloodtypesConfiguration());

            modelBuilder.Entity<Cities>(entity =>
            {
                entity.ToTable("cities");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(45);
            });

            modelBuilder.Entity<Defunciones>(entity =>
            {
                entity.HasKey(e => e.Serial)
                    .HasName("PRIMARY");

                entity.ToTable("defunciones");

                entity.HasIndex(e => e.MedicId)
                    .HasName("fk_defunciones_medic_id_idx");

                entity.HasIndex(e => e.NotaryId)
                    .HasName("fk_defunciones_notary_id_idx");

                entity.HasIndex(e => e.PlaceId)
                    .HasName("fk_nacimientos_places_id_idx");

                entity.HasIndex(e => e.RelateduserId)
                    .HasName("fk_nacimientos_relateduser_id_idx");

                entity.HasIndex(e => e.WitnessId)
                    .HasName("fk_nacimientos_witness1_id_idx");

                entity.Property(e => e.Serial)
                    .HasColumnName("serial")
                    .HasMaxLength(15);

                entity.Property(e => e.AttachDescription)
                    .IsRequired()
                    .HasColumnName("attach_description")
                    .HasMaxLength(75);

                entity.Property(e => e.DeadDate)
                    .HasColumnName("dead_date")
                    .HasColumnType("date");

                entity.Property(e => e.Fileroute)
                    .HasColumnName("fileroute")
                    .HasMaxLength(500);

                entity.Property(e => e.MedicId)
                    .IsRequired()
                    .HasColumnName("medic_id")
                    .HasMaxLength(15);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(50);

                entity.Property(e => e.NotaryId)
                    .IsRequired()
                    .HasColumnName("notary_id")
                    .HasMaxLength(15);

                entity.Property(e => e.PlaceId).HasColumnName("place_id");

                entity.Property(e => e.RegDate)
                    .HasColumnName("reg_date")
                    .HasColumnType("date");

                entity.Property(e => e.RelateduserId)
                    .HasColumnName("relateduser_id")
                    .HasMaxLength(15);

                entity.Property(e => e.Surname)
                    .IsRequired()
                    .HasColumnName("surname")
                    .HasMaxLength(50);

                entity.Property(e => e.WitnessId)
                    .IsRequired()
                    .HasColumnName("witness_id")
                    .HasMaxLength(15);

                entity.HasOne(d => d.Medic)
                    .WithMany(p => p.Defunciones)
                    .HasForeignKey(d => d.MedicId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_defunciones_medic_id");

                entity.HasOne(d => d.Notary)
                    .WithMany(p => p.Defunciones)
                    .HasForeignKey(d => d.NotaryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_defunciones_notary_id");

                entity.HasOne(d => d.Place)
                    .WithMany(p => p.Defunciones)
                    .HasForeignKey(d => d.PlaceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_defunciones_places_id");

                entity.HasOne(d => d.Relateduser)
                    .WithMany(p => p.DefuncionesRelateduser)
                    .HasForeignKey(d => d.RelateduserId)
                    .HasConstraintName("fk_defunciones_relateduser1_id");

                entity.HasOne(d => d.Witness)
                    .WithMany(p => p.DefuncionesWitness)
                    .HasForeignKey(d => d.WitnessId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_defunciones_witness1_id");
            });

            modelBuilder.Entity<Departments>(entity =>
            {
                entity.ToTable("departments");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(50);
            });

            modelBuilder.ApplyConfiguration(new DoctypesConfiguration());

            modelBuilder.Entity<MatAttaches>(entity =>
            {
                entity.HasKey(e => e.AttachId)
                    .HasName("PRIMARY");

                entity.ToTable("mat_attaches");

                entity.Property(e => e.AttachId).HasColumnName("attach_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Matrimonios>(entity =>
            {
                entity.HasKey(e => e.Serial)
                    .HasName("PRIMARY");

                entity.ToTable("matrimonios");

                entity.HasIndex(e => e.AttachId)
                    .HasName("fk_matrimonios_attach_id_idx");

                entity.HasIndex(e => e.NotaryId)
                    .HasName("fk_matrimonios_notary_id_idx");

                entity.HasIndex(e => e.PlaceId)
                    .HasName("fk_nacimientos_places_id_idx");

                entity.HasIndex(e => e.Relateduser1Id)
                    .HasName("fk_nacimientos_relateduser_id_idx");

                entity.HasIndex(e => e.Relateduser2Id)
                    .HasName("fk_matrimonios_relateduser2_id_idx");

                entity.HasIndex(e => e.WitnessId)
                    .HasName("fk_nacimientos_witness1_id_idx");

                entity.Property(e => e.Serial)
                    .HasColumnName("serial")
                    .HasMaxLength(15);

                entity.Property(e => e.AttachDescription)
                    .IsRequired()
                    .HasColumnName("attach_description")
                    .HasMaxLength(75);

                entity.Property(e => e.AttachId).HasColumnName("attach_id");

                entity.Property(e => e.Fileroute)
                    .HasColumnName("fileroute")
                    .HasMaxLength(500);

                entity.Property(e => e.Name1)
                    .IsRequired()
                    .HasColumnName("name1")
                    .HasMaxLength(50);

                entity.Property(e => e.Name2)
                    .IsRequired()
                    .HasColumnName("name2")
                    .HasMaxLength(45);

                entity.Property(e => e.NotaryId)
                    .IsRequired()
                    .HasColumnName("notary_id")
                    .HasMaxLength(15);

                entity.Property(e => e.PlaceId).HasColumnName("place_id");

                entity.Property(e => e.RegDate)
                    .HasColumnName("reg_date")
                    .HasColumnType("date");

                entity.Property(e => e.Relateduser1Id)
                    .HasColumnName("relateduser1_id")
                    .HasMaxLength(15);

                entity.Property(e => e.Relateduser2Id)
                    .HasColumnName("relateduser2_id")
                    .HasMaxLength(45);

                entity.Property(e => e.Surname1)
                    .IsRequired()
                    .HasColumnName("surname1")
                    .HasMaxLength(50);

                entity.Property(e => e.Surname2)
                    .IsRequired()
                    .HasColumnName("surname2")
                    .HasMaxLength(50);

                entity.Property(e => e.WeedingDate)
                    .HasColumnName("weeding_date")
                    .HasColumnType("date");

                entity.Property(e => e.WitnessId)
                    .IsRequired()
                    .HasColumnName("witness_id")
                    .HasMaxLength(15);

                entity.HasOne(d => d.Attach)
                    .WithMany(p => p.Matrimonios)
                    .HasForeignKey(d => d.AttachId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_matrimonios_attach_id");

                entity.HasOne(d => d.Notary)
                    .WithMany(p => p.Matrimonios)
                    .HasForeignKey(d => d.NotaryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_matrimonios_notary_id");

                entity.HasOne(d => d.Place)
                    .WithMany(p => p.Matrimonios)
                    .HasForeignKey(d => d.PlaceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_matrimonios_places_id");

                entity.HasOne(d => d.Relateduser1)
                    .WithMany(p => p.MatrimoniosRelateduser1)
                    .HasForeignKey(d => d.Relateduser1Id)
                    .HasConstraintName("fk_matrimonios_relateduser1_id");

                entity.HasOne(d => d.Relateduser2)
                    .WithMany(p => p.MatrimoniosRelateduser2)
                    .HasForeignKey(d => d.Relateduser2Id)
                    .HasConstraintName("fk_matrimonios_relateduser2_id");

                entity.HasOne(d => d.Witness)
                    .WithMany(p => p.MatrimoniosWitness)
                    .HasForeignKey(d => d.WitnessId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_matrimonios_witness1_id");
            });

            modelBuilder.Entity<Medicos>(entity =>
            {
                entity.ToTable("medicos");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(15);

                entity.Property(e => e.MedicCard)
                    .IsRequired()
                    .HasColumnName("medic_card")
                    .HasMaxLength(15);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(50);

                entity.Property(e => e.Surname)
                    .IsRequired()
                    .HasColumnName("surname")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<NacAttaches>(entity =>
            {
                entity.HasKey(e => e.AttachId)
                    .HasName("PRIMARY");

                entity.ToTable("nac_attaches");

                entity.Property(e => e.AttachId).HasColumnName("attach_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Nacimientos>(entity =>
            {
                entity.HasKey(e => e.Nuip)
                    .HasName("PRIMARY");

                entity.ToTable("nacimientos");

                entity.HasIndex(e => e.AttachId)
                    .HasName("fk_nacimientos_attach_id_idx");

                entity.HasIndex(e => e.BloodtypeId)
                    .HasName("fk_nacimientos_bloodtype_id_idx");

                entity.HasIndex(e => e.DadId)
                    .HasName("fk_nacimientos_dad_id_idx");

                entity.HasIndex(e => e.MomId)
                    .HasName("fk_nacimientos_mom_id_idx");

                entity.HasIndex(e => e.NotaryId)
                    .HasName("fk_nacimientos_notary_id_idx");

                entity.HasIndex(e => e.PlaceId)
                    .HasName("fk_nacimientos_places_id_idx");

                entity.HasIndex(e => e.RelateduserId)
                    .HasName("fk_nacimientos_relateduser_id_idx");

                entity.HasIndex(e => e.WitnessId)
                    .HasName("fk_nacimientos_witness1_id_idx");

                entity.Property(e => e.Nuip)
                    .HasColumnName("nuip")
                    .HasMaxLength(15);

                entity.Property(e => e.AttachDescription)
                    .IsRequired()
                    .HasColumnName("attach_description")
                    .HasMaxLength(75);

                entity.Property(e => e.AttachId).HasColumnName("attach_id");

                entity.Property(e => e.BloodtypeId).HasColumnName("bloodtype_id");

                entity.Property(e => e.DadId)
                    .IsRequired()
                    .HasColumnName("dad_id")
                    .HasMaxLength(15);

                entity.Property(e => e.Fileroute)
                    .HasColumnName("fileroute")
                    .HasMaxLength(500);

                entity.Property(e => e.MomId)
                    .IsRequired()
                    .HasColumnName("mom_id")
                    .HasMaxLength(15);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(50);

                entity.Property(e => e.NotaryId)
                    .IsRequired()
                    .HasColumnName("notary_id")
                    .HasMaxLength(15);

                entity.Property(e => e.PlaceId).HasColumnName("place_id");

                entity.Property(e => e.RelateduserId)
                    .HasColumnName("relateduser_id")
                    .HasMaxLength(15);

                entity.Property(e => e.Serial)
                    .IsRequired()
                    .HasColumnName("serial")
                    .HasMaxLength(15);

                entity.Property(e => e.Sex)
                    .IsRequired()
                    .HasColumnName("sex")
                    .HasMaxLength(1)
                    .IsFixedLength();

                entity.Property(e => e.Surname1)
                    .IsRequired()
                    .HasColumnName("surname1")
                    .HasMaxLength(50);

                entity.Property(e => e.Surname2)
                    .IsRequired()
                    .HasColumnName("surname2")
                    .HasMaxLength(50);

                entity.Property(e => e.WitnessId)
                    .IsRequired()
                    .HasColumnName("witness_id")
                    .HasMaxLength(15);

                entity.Property(e => e.BirthHour)
                    .HasColumnName("birth_hour")
                    .HasColumnType("time");

                entity.Property(e => e.BirthDate)
                    .HasColumnName("birth_date")
                    .HasColumnType("date");

                entity.Property(e => e.RegDate)
                    .HasColumnName("reg_date")
                    .HasColumnType("date");

                entity.HasOne(d => d.Attach)
                    .WithMany(p => p.Nacimientos)
                    .HasForeignKey(d => d.AttachId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_nacimientos_attach_id");

                entity.HasOne(d => d.Bloodtype)
                    .WithMany(p => p.Nacimientos)
                    .HasForeignKey(d => d.BloodtypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_nacimientos_bloodtype_id");

                entity.HasOne(d => d.Dad)
                    .WithMany(p => p.NacimientosDad)
                    .HasForeignKey(d => d.DadId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_nacimientos_dad_id");

                entity.HasOne(d => d.Mom)
                    .WithMany(p => p.NacimientosMom)
                    .HasForeignKey(d => d.MomId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_nacimientos_mom_id");

                entity.HasOne(d => d.Notary)
                    .WithMany(p => p.Nacimientos)
                    .HasForeignKey(d => d.NotaryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_nacimientos_notary_id");

                entity.HasOne(d => d.Place)
                    .WithMany(p => p.Nacimientos)
                    .HasForeignKey(d => d.PlaceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_nacimientos_places_id");

                entity.HasOne(d => d.Relateduser)
                    .WithMany(p => p.NacimientosRelateduser)
                    .HasForeignKey(d => d.RelateduserId)
                    .HasConstraintName("fk_nacimientos_relateduser_id");

                entity.HasOne(d => d.Witness)
                    .WithMany(p => p.NacimientosWitness)
                    .HasForeignKey(d => d.WitnessId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_nacimientos_witness1_id");
            });

            modelBuilder.Entity<Notarios>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PRIMARY");

                entity.ToTable("notarios");

                entity.Property(e => e.UserId)
                    .HasColumnName("user_id")
                    .HasMaxLength(15);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title")
                    .HasMaxLength(50);

                entity.HasOne(d => d.User)
                    .WithOne(p => p.Notarios)
                    .HasForeignKey<Notarios>(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_notarios_user_id");
            });

            modelBuilder.Entity<Places>(entity =>
            {
                entity.HasKey(e => e.PlaceId)
                    .HasName("PRIMARY");

                entity.ToTable("places");

                entity.HasIndex(e => e.CityId)
                    .HasName("fk_places_city_id_idx");

                entity.HasIndex(e => e.DepartmentId)
                    .HasName("fk_places_department_id_idx");

                entity.Property(e => e.PlaceId).HasColumnName("place_id");

                entity.Property(e => e.CityId).HasColumnName("city_id");

                entity.Property(e => e.DepartmentId).HasColumnName("department_id");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.Places)
                    .HasForeignKey(d => d.CityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_places_city_id");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.Places)
                    .HasForeignKey(d => d.DepartmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_places_department_id");
            });

            modelBuilder.Entity<Usuarios>(entity =>
            {
                entity.ToTable("usuarios");

                entity.HasIndex(e => e.DoctypeId)
                    .HasName("fk_doctypes_usuarios_idx");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(15);

                entity.Property(e => e.BirthDate)
                    .HasColumnName("birth_date")
                    .HasColumnType("date");

                entity.Property(e => e.DoctypeId).HasColumnName("doctype_id");

                entity.Property(e => e.ExpeditionDate)
                    .HasColumnName("expedition_date")
                    .HasColumnType("date");

                entity.Property(e => e.ExpeditionPlace)
                    .HasColumnName("expedition_place")
                    .HasMaxLength(100);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(50);

                entity.Property(e => e.Surname)
                    .IsRequired()
                    .HasColumnName("surname")
                    .HasMaxLength(50);

                entity.HasOne(d => d.Doctype)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.DoctypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_usuarios_doctype_id");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

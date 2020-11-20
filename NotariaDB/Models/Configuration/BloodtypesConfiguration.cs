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
            builder.HasData(
                seeder.Run()
            );
        }
    }
}

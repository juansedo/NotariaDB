# NotariaDB
Database software for Salgar notary

# NuGet packages
- MySql.Data (v8.0.22)
- MySql.Data.EntityFrameworkCore (v8.0.22)
- Microsoft.EntityFrameworkCore (v3.1.9)
- Microsoft.EntityFrameworkCore.Tools (v3.1.9)

Command for generating Entity Framework DBcontext using NuGet Package Manager Console:
```
Scaffold-DBContext "<connectionString>" -O <OutputDir>

# Migración basada en el modelo
Add-Migration

# Actualiza la base de datos según la última migración
Update-Database
```
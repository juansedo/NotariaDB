# NotariaDB

NotariaDB is a program that manages the birth, marriage and death records created by a notary's office. Currently **not functional** and still under development.

## Getting started

First, the files from this repository must be downloaded.

To run this project you need a database server running on the local machine. Installation of [**MySQL Workbench**](https://dev.mysql.com/downloads/workbench/) recommended. It includes a graphical interface to work with the databases and the local server.

Desde MySQL Workbench se debe hacer la conexión al servidor local y ejecutar el archivo [**init_db.sql**](init_db.sql).

Otra aplicación necesaria es [**Visual Studio Community**](https://visualstudio.microsoft.com/es/vs/community/), desde la que se puede ejecutar el código y previsualizar las interfaces gráficas que se han creado.

Una vez instalado, se debe abrir el archivo [NotariaDB.sln](NotariaDB.sln) con Visual Studio Community y ejecutar el código. Siempre que el servidor esté encendido y en la base de datos exista el usuario **root** con la contraseña vacía, funcionará.

Próximamente, se automatizará este proceso a través de comandos en la terminal de paquetes NuGet:
```bash
# For generating models
Scaffold-DBContext "<connectionString>" MySql.Data.EntityFrameworkCore -O <OutputDir>

# For creating migrations using the main model
Add-Migration <name>

# For starting migration process
Update-Database
```

## Built with 🛠️

* [Entity Framework](https://github.com/dotnet/ef6) - C# Framework for database connections
* [NuGet](https://www.nuget.org/) - Visual Studio's default package manager

## Authors ✒️

* **David Calle González** - [dcalleg707](https://github.com/dcalleg707)
* **Juan Sebastián Díaz Osorio** - [juansedo](https://github.com/juansedo)
* **Santiago Hidalgo Ocampo** - [sanhidalgoo](https://github.com/sanhidalgoo)

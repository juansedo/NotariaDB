# NotariaDB

NotariaDB is a program that manages the birth, marriage and death records created by a notary's office. Currently **not functional** and still under development.

## Getting started

First, the files from this repository must be downloaded.

To run this project you need a database server running on the local machine. Installation of [**MySQL Workbench**](https://dev.mysql.com/downloads/workbench/) recommended. It includes a graphical interface to work with the databases and the local server.

From MySQL Workbench you must make the connection to the local server and execute [**init_db.sql**](init_db.sql) file.

Another necessary application is [**Visual Studio Community**](https://visualstudio.microsoft.com/es/vs/community/), from which you can run the code and preview the graphical interfaces that have been created.

Once installed, the file [NotariaDB.sln](NotariaDB.sln) must be opened with Visual Studio Community and the code run. As long as the server is on and there is a ** root ** user in the database with an empty password, it will work.

Soon, this process will be automated through commands in the NuGet package terminal:
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

# NotariaDB
NotariaDB es un programa con el que se gestionan los registros de nacimiento, matrimonio y defunción creados por una notaría. Actualmente **no es funcional** y sigue en desarrollo.

## Getting started

Primero, se deben descargar los archivos de este repositorio.

Para ejecutar este proyecto se necesita un servidor de bases de datos corriendo en la máquina local. Se recomienda la instalación de [**MySQL Workbench**](https://dev.mysql.com/downloads/workbench/) que incluye una interfaz gráfica para trabajar con las bases de datos y el servidor local.

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

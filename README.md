# SOURCE : https://learn.microsoft.com/en-us/aspnet/core/tutorials/first-web-api?view=aspnetcore-7.0&tabs=visual-studio-code#tabpanel_2_visual-studio-code

# Setup

```
// Init proyects.
'dotnet new webapi -o TodoApi'

// Install in-memory database provider.
'dotnet add package Microsoft.EntityFrameworkCore.InMemory'

* Simulates the behavior of an in-memory SQL database in the application. In other words, it is a temporary database that is stored in the RAM of the application while it is running. *

// Trust the HTTPS development certificate.
'dotnet dev-certs https --trust'

*
    - Generates a self-signed certificate if one does not already exist.

    - Adds the certificate to the system certificate store and establishes trust on the certificate so that browsers and clients trust it when establishing an HTTPS connection.

This is especially useful during development as it avoids security issues related to self-signed certificates and ensures that the HTTPS connection works smoothly in the local development environment.
*
```

```
// Run the app.
'dotnet run --launch-profile https'

```

# Scaffold

- In the context of web applications, it refers to the automatic generation of code bases, file structures, and code templates that are necessary to build certain parts of an application.
- The primary goal of the scaffold is to speed up the development process by providing a foundation from which developers can start working, avoiding manual writing of repetitive code.

```
dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design -v 7.0.0
```

- **Microsoft.VisualStudio.Web.CodeGeneration.Design**: This package provides tools for generating code structures related to ASP.NET MVC and Razor Pages. These tools allow you to automatically generate code for controllers, views, Razor pages, and other artifacts in your web application. They are useful for speeding up web application development in ASP.NET by automatically generating the code needed for CRUD actions and web pages.

```
dotnet add package Microsoft.EntityFrameworkCore.Design -v 7.0.0
```

- **Microsoft.EntityFrameworkCore.Design**: Yes, Entity Framework Core (EF Core) is an ORM (Object-Relational Mapping) that allows you to interact with relational databases from your .NET application. You can think of EF Core as similar to Sequelize in the Node.js world, as both are ORMs that simplify interaction with relational databases by mapping objects in your application to tables in the database and vice versa. Microsoft.EntityFrameworkCore.Design provides additional tools for database design and management with EF Core, such as generating models from an existing database and creating schema migrations.

```
dotnet add package Microsoft.EntityFrameworkCore.SqlServer -v 7.0.0
```

- **Microsoft.EntityFrameworkCore.SqlServer**: This package is a specific provider for SQL Server used in combination with Entity Framework Core. Entity Framework Core supports several database providers, including SQL Server, MySQL, PostgreSQL, and more. Microsoft.EntityFrameworkCore.SqlServer enables specific functionality for interacting with SQL Server databases from your .NET application through EF Core. Each database vendor has its own package that is used to enable support for that specific database management system. Therefore, if you want to use SQL Server as your database, adding this package is essential to enable SQL Server functionality in EF Core.

Then, execute:

```
dotnet tool uninstall -g dotnet-aspnet-codegenerator
dotnet tool install -g dotnet-aspnet-codegenerator
dotnet tool update -g dotnet-aspnet-codegenerator
```

Run the following command to generate a template:

```
dotnet aspnet-codegenerator controller -name TodoItemsController -async -api -m TodoItem -dc TodoContext -outDir Controllers
```

- Generates a controller named **TodoItemsController**(- name), where the methods are of type **async**(-async) and it is of type **api**(-api).
- This controller will be related to the TodoItem(-m) model, using the data context (DB connection) **TodoContext**(-dc), and the generated file will be placed in the directory **Controllers**(-- outDir).
# todo-api

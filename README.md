<div align="center">
    <h1>.NET Core Clinic</h1>
    <h3>
        <a href="#">
            Live demo
        </a>
        <span> | </span>
        <a href="https://github.com/everstudybee/s6-dotnet-core-clinic">
            GitHub
        </a>
    </h3>
    <p>Web app for Clinic</p>
    <p><b>Status:</b> 🛠️ The application is in active development 🛠️</p>
    <br>
    <p>Technologies and tools:</p>
    <p>
        <img src="docs/img/dotnet.svg" width="40" height="40" alt="dotnet"/>
        <img src="docs/img/csharp.svg" width="40" height="40" alt="csharp"/>
        <img src="docs/img/sqlserver.svg" width="40" height="40" alt="sqlserver"/>
        <img src="docs/img/html5.svg" width="40" height="40" alt="html"/>
        <img src="docs/img/css3.svg" width="40" height="40" alt="css"/>
        <img src="docs/img/materialize.svg" width="40" height="40" alt="materialize"/>
        <img src="docs/img/tailwind.svg" width="40" height="40" alt="tailwind"/>
        <img src="docs/img/js.svg" width="40" height="40" alt="javascript"/>
        <img src="docs/img/md.svg" width="40" height="40" alt="markdown"/>
        <img src="docs/img/git.svg" width="40" height="40" alt="git"/>
        <img src="docs/img/github.svg" width="40" height="40" alt="github"/>
        <img src="docs/img/vs.svg" width="40" height="40" alt="visualstudio2022"/>
    </p>
</div>
<br>

### DESCRIPTION

Web application for managing the Clinic. It enables the registration of doctors, patients and visits.

Main assumptions:

- The division of the solution into projects:
   - `Clinic.DataAccess` - Data Access Layer (DAL)
   - `Clinic.Entities` - Data Transfer Objects (DTOs) and seeding configuration
   - `Clinic.Logic` - Business Logic Layer (BLL)
   - `Clinic.WebAdmin` - website for administrators
   - `Clinic.WebPatient` - website for patients
- MS SQL Server database,
- Code-First approach,
- Seeding 

### Configuring the Clinic.Database project to create a temporary context when using the wizards

To use the wizards correctly, the Clinic.Database project must contain an additional class that creates a temporary context 
- https://github.com/dotnet/Scaffolding/issues/1765#issuecomment-1058674843
- https://learn.microsoft.com/en-us/ef/core/cli/dbcontext-creation?tabs=dotnet-core-cli#from-a-design-time-factory

### Configuration of packages in projects

#### Packages in Clinic.Databse project

1. Explicitly, you only need to declare these packages. Packages appearing as dependencies can also be declared explicitly, but this only results in the information about the possibility of their update.
   - `Microsoft.EntityFrameworkCore.SqlServer`
1. The rest of the packages act as dependencies on other packages.
   - `Microsoft.EntityFrameworkCore.Relational`
   - `Microsoft.EntityFrameworkCore`

#### Packages in Clinic.Admin and Clinic.Web projects

1. Explicitly, you only need to declare these packages. Packages appearing as dependencies can also be declared explicitly, but this only results in the information about the possibility of their update.
   - `Microsoft.EntityFrameworkCore.SqlServer`
   - `Microsoft.EntityFrameworkCore.Tools`
1. The rest of the packages act as dependencies on other packages.
   - `Microsoft.EntityFrameworkCore.Relational`
   - `Microsoft.EntityFrameworkCore`
   - `Microsoft.EntityFrameworkCore.Design`

### Seeding

1. Add seeding with main data - https://code-maze.com/migrations-and-seed-data-efcore/
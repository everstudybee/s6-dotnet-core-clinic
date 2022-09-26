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

Web application for managing the Clinic. It enables the registration of doctors, patients and visits. MS SQL Server database, Code-First approach. 

### ASP.NET Core MVC web app: controller wizard issue

1. [Stackoverflow](https://stackoverflow.com/questions/73833413/asp-net-core-mvc-web-app-controller-wizard-issue)
2. [GitHub dotnet/Scaffolding](https://github.com/dotnet/Scaffolding/issues/2019)  
3. [Youtube - .NET Identity Scaffolding Error](https://youtu.be/VFq4aeP0XWQ)

Solution
1. The solution is in the last link
1. Copy the model from `Clinic.Database`. Entire `Data` folder. Do not modify `namespace`.
1. Create a commit in `Git` to see all changes after running the wizard.
1. In a temporary project, run the appropriate `wizard`.
1. **Clinic Context.cs**
   - `Clinic.Database\Data` 
1. **appsettings.json**
   - `Clinic.Web` 
   - `Clinic.Admin`
1. **Program.cs**
   - `Clinic.Web` 
   - `Clinic.Admin`
1. **Clinic.Web and Clinic.Admin**
   - `Microsoft.EntityFrameworkCore.Tools` 
1. **Views**
   - Copy folder with created pages
     - `Clinic.Web` 
     - `Clinic.Admin`
   - You do not need to change the model.
1. **PagesController.cs**
   - `Clinic.Web` 
   - `Clinic.Admin`

### TODO

Comandos a ejecutar

dotnet tool install -g dotnet-aspnet-codegenerator
dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add package Microsoft.AspNetCore.Identity.EntityFrameworkCore
dotnet add package Microsoft.AspNetCore.Identity.UI
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.EntityFrameworkCore.Tools
dotnet aspnet-codegenerator identity -h
dotnet aspnet-codegenerator identity -dc Tarea6.Data.ApplicationDbContext -lf 
dotnet aspnet-codegenerator identity -dc Tarea6.Data.ApplicationDbContext --files 
"Account.Register;Account.Login;Account.Manage._Layout;Account.Manage._ManageNav;
Account.Manage.Index;Account.Manage.PersonalData"
dotnet tool install --global dotnet-ef
dotnet ef database drop
dotnet ef migrations remove
dotnet ef migrations add InitialCreate
dotnet ef database update

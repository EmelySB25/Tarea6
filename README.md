<b>Comandos a ejecutar<b/>

<b>dotnet tool install -g dotnet-aspnet-codegenerator<b/>

<b>dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design<b/>

<b>dotnet add package Microsoft.EntityFrameworkCore.Design<b/>

<b>dotnet add package Microsoft.AspNetCore.Identity.EntityFrameworkCore<b/>

<b>dotnet add package Microsoft.AspNetCore.Identity.UI<b/>

<b>dotnet add package Microsoft.EntityFrameworkCore.SqlServer<b/>

<b>dotnet add package Microsoft.EntityFrameworkCore.Tools<b/>

<b>dotnet aspnet-codegenerator identity -h<b/>

<b>dotnet aspnet-codegenerator identity -dc Tarea6.Data.ApplicationDbContext -lf <b/>

<b>dotnet aspnet-codegenerator identity -dc Tarea6.Data.ApplicationDbContext --files 
"Account.Register;Account.Login;Account.Manage._Layout;Account.Manage._ManageNav;
Account.Manage.Index;Account.Manage.PersonalData"<b/>

<b>dotnet tool install --global dotnet-ef<b/>

<b>dotnet ef database drop<b/>

<b>dotnet ef migrations remove<b/>

<b>dotnet ef migrations add InitialCreate<b/>

<b><b/>

<b>dotnet ef database update<b/>

<b><b/>

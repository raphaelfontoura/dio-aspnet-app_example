
### Comandos executados no projeto:
---
```bash
$ dotnet new sln -n CursoMVC

$ dotnet new mvc --name CursoMVC

$ dotnet sln add CursoMVC/CursoMVC.csproj

$ dotnet sln list

$ dotnet restore

$ dotnet build CursoMVC.sln

$ dotnet new gitignore

$ dotnet new globaljson --sdk-version 3.1.410

$ dotnet add package Microsoft.EntityFrameworkCore.SqlServer

$ dotnet add package Microsoft.EntityFrameworkCore.Tools

$ dotnet ef migrations add InitialCreate

$ dotnet ef database update

$ dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design -v 3.1.0

$ dotnet aspnet-codegenerator controller -name CategoryController -m Category -dc Context -outDir Controllers -udl -scripts
```
Após a criação do model Products e adicioar o model na classe Context:
```bash
$ dotnet ef migrations add TableProducts
$ dotnet ef database update
```
Então criamos o controller de Products:
```bash
$ dotnet aspnet-codegenerator controller -name ProductController -m Product -dc Context -outDir Controllers -udl -scripts
```

<br>

### Links visitados:
---

https://docs.microsoft.com/pt-br/aspnet/core/tutorials/first-mvc-app/adding-controller?view=aspnetcore-5.0&tabs=visual-studio-code

http://www.macoratti.net/18/01/aspcore_scfdlcmd1.htm
http://www.macoratti.net/17/12/aspcore_ctrlcmd2.htm

https://mycsharpdeveloper.wordpress.com/2020/04/22/how-to-scaffolding-asp-net-core-mvc-view-and-controller-in-visual-studio-code/

https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/adding-model?view=aspnetcore-3.1&tabs=visual-studio-code

https://docs.microsoft.com/en-us/aspnet/core/fundamentals/tools/dotnet-aspnet-codegenerator?view=aspnetcore-3.1

https://github.com/dotnet/Scaffolding/issues/1347

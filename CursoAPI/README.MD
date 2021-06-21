## Comandos executados:
---
```bash
$ dotnet new globaljson --sdk-version 3.1.410
$ dotnet new webapi -n CursoAPI
$ dotnet sln add CursoAPI/CursoAPI.csproj
$ dotnet add reference ../CursoMVC/CursoMVC.csproj 
$ dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design -v 3.1.0

$ dotnet add package Microsoft.EntityFrameworkCore.Design
$ dotnet aspnet-codegenerator controller -name CategoryController -outDir Controllers -p CursoAPI.csproj -m Category -dc Context -api -nv

$ dotnet aspnet-codegenerator controller -name ProductController -outDir Controllers -p CursoAPI.csproj -m Product -dc Context -api -nv
```

<br>

## Links:
---
>https://docs.microsoft.com/pt-br/dotnet/core/tools/dotnet-add-reference

>https://docs.microsoft.com/pt-br/aspnet/core/fundamentals/tools/dotnet-aspnet-codegenerator?view=aspnetcore-5.0

>https://developerslogblog.wordpress.com/2019/07/02/how-to-create-a-net-core-multi-project-solution-in-linux/

>https://elanderson.net/2018/04/run-multiple-projects-in-visual-studio-code/

>https://wakeupandcode.com/debugging-multiple-net-core-projects-in-vs-code/

<br>

## Executando:
---
```bash
$ dotnet restore
$ dotnet run
```
Link para Swagger:
https://localhost:5003/swagger

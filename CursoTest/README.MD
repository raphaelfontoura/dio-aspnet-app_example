## Comandos executados:
---
```bash
$ dotnet new xunit -n CursoTest
$ dotnet sln add CursoTest/CursoTest.csproj 
$ dotnet add CursoTest/CursoTest.csproj reference CursoAPI/CursoAPI.csproj 
$ dotnet add CursoTest/CursoTest.csproj reference CursoMVC/CursoMVC.csproj 

$ dotnet add CursoTest/CursoTest.csproj package Microsoft.EntityFrameworkCore.SqlServer
$ dotnet add CursoTest/CursoTest.csproj package Microsoft.EntityFrameworkCore.Tools
$ dotnet add CursoTest/CursoTest.csproj package Moq

$ cd CursoTest/
$ dotnet new gitignore
```

<br>

## Links:

>https://docs.microsoft.com/pt-br/dotnet/csharp/language-reference/keywords/virtual
>https://docs.microsoft.com/pt-br/dotnet/csharp/language-reference/keywords/override

O Mock utiliza "override" para sobrescrever os métodos da classe. Por isso o mesmo precisa estar com o modificador de acesso "virtual".

>https://www.thecodebuzz.com/moq-to-mock-asynchronous-method-net-core-unit-tests/
>https://www.thecodebuzz.com/restful-api-controller-unit-testing-best-practices/

# ApiMySqlNetCore3.1


# Este proyecto fue hecho en linux

  Comando para crearlo : dotnet new webapi -o ApiNet ;      (ApiNet es el nombre del proyecto)
  
# Para crear ésta API se tienen que instalar las siguientes librerias :



* dotnet add package Pomelo.EntityFrameworkCore.MySql --version 5.0.0-alpha.2
* dotnet add package Microsoft.EntityFrameworkCore
* dotnet add package Microsoft.EntityFrameworkCore.Design
* dotnet add package Microsoft.EntityFrameworkCore.Tools
* dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design


# Para crear un controlador basado en un modelo y contexto previamente generados se utiliza el siguiente comando :

* dotnet aspnet-codegenerator controller -name UsuarioController -async -api -m Usuarios -dc Contexto -outDir Controllers

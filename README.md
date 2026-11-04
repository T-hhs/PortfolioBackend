DOTNET MINIMAL API PROJECT

-Web API project

-Minimal API structure

dotnet version: 10.0.401

database: PostgreSQL 18.6

database connection packages:
EF Core 10.0.14
EF Core Postgre 10.0.0


Install steps to run project

-install postgre, in pg admin, create database named "portbackend", remember/note your created password

-inside project cli, input the following:

dotnet user-secrets init

dotnet user-secrets set "ConnectionStrings:backendDB_Correct"
"Host=localhost;Database=portbackend;Username=postgres;Password=YOUR_PASSWORD_HERE" -password used in database creation

dotnet ef migrations add InitialCreate

dotnet ef database update

Project is now ready to be run, to start, do the following:

-input into project cli 'dotnet run'

-in browser, go to "http://localhost:5074/swagger/index.html"

# People Hub

Small project to practice EF Core and DDD.

## Built with

- .Net Core
- Entity Framework Core
- Domain Driven Design

## Create & Run database

Create a MySQL database container running the command :

```
docker run --name peoplehubdb -e MYSQL_ROOT_PASSWORD=r00t -e MYSQL_DATABASE=peoplehubdb -p 7070:3306  -d mysql
```

In the People.Infra.Data, run migrations to create tables :

```
dotnet ef database update --startup-project ../PeopleHub.Api
```

## Run the application

```
dotnet run
```

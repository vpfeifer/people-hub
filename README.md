# People Hub

Small project to practice EF Core and DDD.

## Built with

- .Net Core
- Entity Framework Core
- Domain Driven Design

## Run database

```
docker run --name peoplehubdb -e MYSQL_ROOT_PASSWORD=r00t -e MYSQL_DATABASE=peoplehubdb -p 7070:3306  -d mysql
```

## Run the application

```
dotnet run
```

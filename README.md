# PerfumeAppAPI

A Backend server side for perfume shop
- RESTful API for user & products management.
- CRUD oprations.

## Table of Contents
- Features
- API Access
- Secrets
## Features:
- SQL Database with Entity Framework Code First.
- Data is seeded on installation.
- LINQ Queries.
- Usage of AutoMapper & DTO's.
- JWT Authentication & Identity Core.
- Authorization: 2 user roles - [ "User", "Admin"].
## API Access
| User  |	Password  | Access |
| :-------- | :------- | :------- |
|admin@email.com| 123!Qaz123|Administrator|
|yoni@email.com| 123!Qaz123|User|
## Secrets
- Open the file secrets.json located in the Perfume Store project folder and set the following key:
bash
`
"Keys": {
"Key": "this is my amazing very Secret key for authentication"
}`
- Open the file appsettings.json located in the Perfume Store project folder and modify the following connection string with your own Microsoft SQL Server database connection string:
`
"ConnectionStrings": {
  "ConnectionString": "Server=<your-server-name>;Database=PerfumeStoreDb;Trusted_Connection = True;TrustServerCertificate= True;
}`
- Open the Package Manager Console in Visual Studio, select the PerfumeStore.Data project, and run the following command to create the database schema:
`
update-database`

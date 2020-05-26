# drugstores-REST
.NET REST project for communication between mysql Database and Everdose through .NET. 

## History

```sql
CREATE DATABASE DotNet;
USE DotNet;
CREATE USER 'userDN'@'localhost' IDENTIFIED BY 'aI8Redn21';
GRANT ALL PRIVILEGES ON DotNet.* TO 'userDN'@'localhost';
```

```sh
dotnet add package Microsoft.EntityFrameworkCore
dotnet add package MySql.Data.EntityFrameworkCore
dotnet add package Microsoft.EntityFrameworkCore.Tools
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet ef dbcontext scaffold "server=localhost;port=3306;user=userDN;password=aI8Redn21;database=DotNet" MySql.Data.EntityFrameworkCore -o Models -f
```

## Running

```sh
dotnet run
```

$ docker pull mcr.microsoft.com/mssql/server
$ docker run --name sqlserver -e "ACCEPT_EULA=Y" -e "MSSQL_SA_PASSWORD=MjM0d2VmZ3NkZmU" -p 1433:1433 -d mcr.microsoft.com/mssql/server

- Connection String: "Server=localhost,1433;Database=balta;User ID=sa;Password=MjM0d2VmZ3NkZmU"
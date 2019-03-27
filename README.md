# Setup the BFF

## Database
As database Postgres is used. Just to be different and not always use SqlServer. The most easy way to get started is to use Docker to get the database up and running. The included docker-compose file will do that for you.

```bash
docker-compose up -d
```

## Seeding the database
1. Create a new database chinook
2. Run the provide sql to seed the database
```bash
scripts\Chinook_Postgres.sql
```
3. Add the user secrets to your environment
```bash
dotnet user-secrets set DefaultConnection "Host=localhost;Database=chinook;Username=root;Password=root1234\!"
```
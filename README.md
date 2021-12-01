# Description

The purpose of this demo is to explore issues `dotnet ef migrations` might have when dealing with unfortunate DbContext class names and namespaces. How to tackle multi-dbcontext migration projects, what naming conventions work and what not.

# Scripts

Create initial migration for `Domain1`

```
$ dotnet ef migrations add Initial --output-dir ./Domain1/Migrations --context Domain1.DbContext1
```

Create initial migration for `Domain2`

```shell
$ dotnet ef migrations add Initial --output-dir ./Domain2/Migrations --context Domain2.DbContext2
```

Create subsequent migrations

```shell
$ dotnet ef migrations add Lookup --context Domain2.DbContext2
```

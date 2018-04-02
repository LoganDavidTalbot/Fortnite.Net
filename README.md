# Fortnite.Net
Unofficial Fortnite Rest Client for the [Fortnite Tracker API](https://fortnitetracker.com/site-api) supporting the .NET Core and Framework platforms.

Currently Allows you to:
- General user information.
- Lifetime stats e.g. KD, total kills, total games, etc.
- Season stats from each of the three main game modes which include this season and last season.
- Stats from the last 10 most recent games.

# Supports
 .Net Standard 2.0, includes .Net Core 2.0 and .Net Framework 4.6.1. [See version conversion table.](https://github.com/dotnet/standard/blob/master/docs/versions.md)

# NuGet
[NuGet Link.](https://www.nuget.org/packages/Fortnite.Net/)

# Install

Package Manager

```Install-Package Fortnite.Net -Version 1.1.0 ```

.NET CLI

```dotnet add package Fortnite.Net --version 1.1.0```

# Getting Started
```
Profile pl = new FortniteClient("API KEY").GetProfile("[PLATFORM pc xbl psn]", "loglt");
```

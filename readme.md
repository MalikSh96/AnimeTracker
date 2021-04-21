# Anime

# First and most import
The branch **`master`** will no longer be used (for now). Due to some previous issues with merging
sub branches into **`master`** - This resulted in important coding and important parts being lost in
the process, and therefore both the **`master`** branch and the sub branches ended up losing data, which resulted
in lost work.

Therefore to try and keep you **up-to-date** with the project, see below header.

# Up-To-Date branches
The most recent branch is:

- **`new_master1`**

# Why ASP.NET
[LINK](https://www.wakefly.com/blog/what-is-asp-net-and-why-should-i-use-it/)

ASP.NET is an open source, server-side web application framework created by Microsoft that runs on Windows.

High speed, low cost, and vast language support are among the most significant benefits. 
ASP.NET is built into the familiar Windows server environment, requiring less setup and 
configuration than other web development platforms that must be installed and configured separately.

As a whole, ASP.NET is a great framework to use when developing web sites and web applications. 
It is reliable, fast, easy to use, free and widely known. 
ASP.NET gives you full control of your development and can be used on any project, big or small

# Installing **dotnet**, ASP.NET on x64 Windows
[Link](https://dotnet.microsoft.com/download) to download **ASP.NET**

**SDK v5.0.201**

# Check if dotnet is installed
Open a command prompt, git bash, powershell or whatever you use, and type in 
`dotnet` to check if you have it installed or not.

# Create webapplication using dotnet
Go to whichever directory you want to create your project
`dotnet new webapp -o NameOfYourProject`

# To run the webapplication
In your command line, `dotnet run`

Creates a folder within your project folder, the `bin` folder.

Also gives you servers to run on.

# Link used to help installing and using dotnet
[LINK](https://www.youtube.com/watch?v=MBdyxWyKBKI)

# What is Microsoft EntityFrameworkCore
Use this [link](https://docs.microsoft.com/en-us/ef/core/).

Entity Framework (EF) is an open source ORM framework for ADO.NET which is a part of .NET Framework.

Entity Framework is an ORM and ORMs are aimed to increase the developer’s productivity by 
reducing the redundant task of persisting the data used in the applications. [Read More](https://www.tutorialspoint.com/entity_framework/entity_framework_overview.htm)

# Using J-Query as search functionality
Link to [script codesnippet](https://docs.microsoft.com/en-us/aspnet/core/mvc/views/tag-helpers/built-in/script-tag-helper?view=aspnetcore-5.0)

J-Query is a lightweight JavaScript library. The purpose of j-query is to make it much easier to use JavaScript
on our website. [Read More](https://www.w3schools.com/jquery/jquery_intro.asp)

# `Dependencies` --> `NuGet`
[Pomelo.EntityFrameworkCore.MySql](https://github.com/PomeloFoundation/Pomelo.EntityFrameworkCore.MySql)

[MySql.Data](https://www.nuget.org/packages/MySql.Data/)

[Microsoft.NETCore.App](https://www.nuget.org/packages/Microsoft.NETCore.App/) A set of .NET API's that are included in the 
default .NET Core application model.

[Microsoft.AspNetCore.App](https://www.nuget.org/packages/Microsoft.AspNetCore.App/)

[Microsoft.VisualStudio.Web.CodeGeneration.Design](https://www.nuget.org/packages/Microsoft.VisualStudio.Web.CodeGeneration.Design/)
Code Generation tool for ASP.NET Core. Contains the dotnet-aspnet-codegenerator command used 
for generating controllers and views. I am using **version 2.1.9** to support my project, as if I use newer 
versions, I won't be able to install packages since they are not compatible.'

[Microsoft.AspNetCore.Razor.Design](https://www.nuget.org/packages/Microsoft.AspNetCore.Razor.Design/) 
Razor is a markup syntax for adding server-side logic to web pages. Again I am using an older version to 
support my project

[PagedList.Core.Mvc](https://www.nuget.org/packages/PagedList.Core.Mvc/)
A tag helper for generating pager control for use with PagedList.Core library. Installed lower version 
for compatibility with my project.

[Microsoft.AspNetCore.Hosting](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.hosting?view=aspnetcore-5.0)
ASP.NET Core hosting infrastructure and startup logic for web applications.

[Microsoft.AspNetCore.Hosting.Abstractions](https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.hosting.server.abstractions?view=aspnetcore-5.0)
Provides types that can be implemented by a server to pool HttpContext instances.

# About some of the `Nuget`
Some of the `NuGet` packages installed may not have been used in the project so far. Whether they will
be used or not, depends on the further development of this project.

Cleaning will be the **absolute** last I will do, once I finish the entire **backend** part.


# AnimeTracker

# Phase 1
# Established connection to database
Used `appsettings.json` to make a connection string as a default connection to my database.

`server=YourServer;port=YourPort;database=YourDbName;uid=YourUser;password=YourPassword`

# `DataContext.cs`
This file contains the establishment of our connection to our database by making a reference to our `appsettings.json`.

`OnConfiguring(DbContextOptionsBuilder optionsBuilder)`, this method to configure the database (and other options) to be 
used for this context. This method is called for each instance of the context that is created. 

[Link](https://docs.microsoft.com/en-us/dotnet/api/microsoft.entityframeworkcore.dbcontext.onconfiguring?view=efcore-5.0)

[About](https://docs.microsoft.com/en-us/dotnet/api/microsoft.entityframeworkcore.dbcontextoptionsbuilder?view=efcore-5.0) 
`DbContextOptionsBuiler`

# `AnimeController.cs`
Under `Controllers` folder.

This file acts as our bridge between our frontend and backend, in this file we do our CRUD operations.

# `Anime.cs`
Under `Models` folder.

This acts as our database entry setup for the particular table 

# DataTables
In each neccessary view that needed a datatable, I have assigned an `id="datatable"` and this `id` is used by the 
`DataTable` script written inside `site.js`

# Views 
Here we design our frontend view on our client.

# Phase 2
Implemented CRUD methods and also j-query search function.

# Phase 3
Implemented functionalities such as when a user wants to see more information about a 
particular anime, the user will be redirected to a **view** that displays more 
information --> `MoreInfo.cshtml` 

Also made that, for the user friendly interface, it will display the list of shows based on 
alphabetical orders.
For the admin page, the list of shows is displayed based on their **ID**, from 1 and above.

# Phase 4
Implemented pagination for `Views/Anime/Index.cshtml`, but the functionality is **NOT** active as of now.

# Phase 5
Installed `DataTables` library directly into `wwwroot/lib`. Made use of this to implement *datatables jquery* 
searching functionality for both `Views/Anime/Search.cshtml` and `Views/Anime/AllAnime.cshtml`.

# Phase 6
Made such, that when adding a show, you are able to, for now, add one image related to the show.
The image will be stored, for now, in the `wwwroot/animeimages` folder.

Further changes will be applied to this phase.

# Phase 7
In `MoreInfo.cshtml` we now display **one** image, for now, for its corresponding show

# Phase 8
Worked further on previous phases for image displaying and such. 
Main coding happened in `AnimeController.cs` --> `public async Task<IActionResult> AddAnime(IFormFile file, Anime anime)` 

I made that once you enter a new entry, based on the `entry.name` a corresponding subfolder gets created.
We use that subfolder to store the images of the given entries, therefore we manage to keep our management cleaner
and more organized when creating entries.

# Phase 9
Completed the work on displaying images and such. Yet again the main coding happened in `AnimeController.cs`

In this phase I made a functionality that dynamically accesses the content of a given folder and displays that content 
on the webpage. In this case the `animeimages` **folder**.

# Phase 10
Worked on some general styling for the different `Views`

# Phase 11
Worked on the `edit` functionality in `AnimeController.cs` - Now when you edit the content of a 
given show you are editing, the `img_path` no longer becomes `null` after editing.

Instead we now *save* the path again into the database.

# Phase 12
Worked on more functionalities, implemented on the two functions `Edit`, `Delete`.

For **`Edit`**
- You are now able to insert more images for the desired show entry, without breaking the folder path
on top of just the editing in general.

- It updates the `img_path` field in the database with the recent image posted, but the images still gets
stored in their respective folders

For **`Delete`**
- When you delete/remove a show from the database, its connected folder, which contains the images, now also
gets deleted from the project.

**EXTRA**

[DirectoryInfo.Delete](https://docs.microsoft.com/en-us/dotnet/api/system.io.directoryinfo.delete?view=net-5.0) 
method.

[Directory.Delete](https://docs.microsoft.com/en-us/dotnet/api/system.io.directory.delete?view=net-5.0) method.

How to deal with the [issue](https://stackoverflow.com/questions/1288718/how-to-delete-all-files-and-folders-in-a-directory) 
of a directory not being empty when trying to *delete*. Check also this [link](https://stackoverflow.com/questions/12415105/directory-is-not-empty-error-when-trying-to-programmatically-delete-a-folder).

# Phase 13
Worked further on the `AddAnime` function. Previously you were able to persist shows which already 
had the same name existing in the database.

Therefore, now you get a message telling you, that the given show you are trying to *add* already exist. And
therefore it does not add a duplicate of the show, based on the name (no matter if it's capital/lower case), into
the database.

`datacontext.MyEntity.Any(a => o.WhatEverYouWantToCompareWith == theInputDataGiven)` --> 
`db.Animes.Any(a => a.animename == anime.animename)`

We use `Any()` because this returns as soon as it finds a match. I am not using SQL because in this entire project, so far,
I haven't used a single SQL yet. This *may* change later on.

[Queryable.Any](https://docs.microsoft.com/en-us/dotnet/api/system.linq.queryable.any?redirectedfrom=MSDN&view=net-5.0#overloads) method.

See also [this](https://stackoverflow.com/questions/1802286/best-way-to-check-if-object-exists-in-entity-framework).


<h1>READER'S REALM</h1>

<p>Design a console-based application in C# for book reviews.
Include functionality for registering a new book, viewing all
registered books, rating, and seeing the average rating.</p>
<p>All the functions for the menu can be fount in the MenuManager.cs file,
and the functions used to register, rate and manage the books can be found
in the LibraryManager.cs file.</p>

<h2>Generating db files:</h2>

<p>You can use Entity Frameowork's own comands to generate the database files.</p>
<p>Here are some examples:</p>

<h3>.NET Core CLI</h3>

```
dotnet ef migrations add InitialCreate
```

```
dotnet ef database update
```

<h3>Visual Studio</h3>

```
Add-Migration InitialCreate
```

```
Update-Database
```

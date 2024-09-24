<h1>READER'S REALM</h1>
<p>Design a console-based application in C# for book reviews.
Include functionality for registering a new book, viewing all
registered books, rating, and seeing the average rating.</p>
<p>All the functions for the menu can be fount in the MenuManager.cs file,
and the functions used to register, rate and manage the books can be found
in the LibraryManager.cs file.</p>

<h2>Generating db files:</h2>
<p>
  All the registered books and their ratings are saved in the db files.
  The ratings are saved as a list, and the average is 
  calculated at Book.cs inside the class Book using Average()
</p>
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
![image](https://github.com/user-attachments/assets/57fb641f-dc45-4770-8aa5-ed85284c11e5)

![Captura de tela de 2024-09-24 11-24-15](https://github.com/user-attachments/assets/76c80cc5-c575-489b-832d-336ed88edb89)

![image](https://github.com/user-attachments/assets/f5001e4a-087c-48b7-a513-98d90334cc9b)

![image](https://github.com/user-attachments/assets/a9f44aa0-229d-41e6-a876-4aa9ab08ff28)


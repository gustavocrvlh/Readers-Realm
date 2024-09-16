public class LibraryManager
{

    private static BookService bookService = new BookService();

    public static void RegisterBook()
    {
        Console.Clear();

        Console.Write("Insert the name of the book you want to register: ");
        string bookName = Console.ReadLine()!;

        Console.Write("Insert the author's name: ");
        string author = Console.ReadLine()!;

        // Adding the variables to the database (BookService.cs)
        bookService.AddBook(bookName, author);

        Console.WriteLine($"The book {bookName}, writen by {author}, was registered successfully");
        Console.Write("Saving...");

        Thread.Sleep(3000);
        MenuManager.ShowOptionsMenu();

    }

    public static void ShowAllBooks()
    {
        Console.Clear();
        var books = bookService.GetAllBooks();

        if (books.Count == 0)
        {
            Console.WriteLine("No books registered yet.");
        }
        else
        {
            Console.WriteLine("Registered books:\n");
            foreach (var book in books)
            {
                Console.WriteLine($"ID: {book.Id}, Name: {book.Name}, Author: {book.Author}");
            }
        }

        Console.WriteLine("\nPress any key to go back to the menu.");
        Console.ReadKey();
        MenuManager.ShowOptionsMenu();
    }

}
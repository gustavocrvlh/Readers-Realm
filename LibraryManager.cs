/*
    Aqui estão todas as funções que alteram ou mostram os dados salvos.
    Here are all the functions that change or show the saved data.
*/

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
                Console.WriteLine(@$"
                Name: {book.Name}
                Author: {book.Author}
                Average Rating: {book.AverageRating:F1}/5
                ");
            }
        }

        Console.WriteLine("\nPress any key to go back to the menu.");
        Console.ReadKey();
        MenuManager.ShowOptionsMenu();
    }

    public static void AddRatingToBook()
    {
        Console.Clear();

        var books = bookService.GetAllBooks();
        if (books.Count == 0)
        {
            Console.WriteLine("No books registered yet.");
            Thread.Sleep(2000);
            MenuManager.ShowOptionsMenu();
            return;
        }

        Console.WriteLine("Registered books:\n");
        foreach (var book in books)
        {
            Console.WriteLine($"ID: {book.Id} | Name: {book.Name} | Author: {book.Author}");
        }

        Console.Write("\nEnter the ID of the book you want to rate: ");
        int bookId;
        if (!int.TryParse(Console.ReadLine(), out bookId))
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
            return;
        }

        Console.Write("Enter your rating (1-5): ");
        int rating;
        if (!int.TryParse(Console.ReadLine(), out rating))
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
            return;
        }

        if (rating < 1 || rating > 5)
        {
            Console.WriteLine("Invalid rating. Please enter a value between 1 and 5.");
            return;
        }

        bookService.AddRating(bookId, rating);

        Console.WriteLine($"Rating of {rating} has been added to the book {bookId}.");
        Thread.Sleep(2000);
        MenuManager.ShowOptionsMenu();
    }

}
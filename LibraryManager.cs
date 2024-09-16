public class LibraryManager
{

    public static void RegisterBook()
    {
        Console.Clear();
        Console.Write("Insert the name of the book you want to register: ");
        string bookName = Console.ReadLine()!;
        Console.Write("Insert the author's name: ");
        string author = Console.ReadLine()!;
        Console.WriteLine($"The book {bookName}, writen by {author}, was registered successfully");
        Console.Write("Saving...");
        Thread.Sleep(3000);
        MenuManager.ShowOptionsMenu();

    }

}
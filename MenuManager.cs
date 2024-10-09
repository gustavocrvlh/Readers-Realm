/*
    Aqui estão todas as funções relacionadas a exibição do menu.
    Here are all the functions related to the menu exibition.
*/

public class MenuManager
{

    public static void ShowTitle()
    {

        Console.WriteLine(@"
    
        ██████╗░███████╗░█████╗░██████╗░███████╗██████╗░██╗░██████╗
        ██╔══██╗██╔════╝██╔══██╗██╔══██╗██╔════╝██╔══██╗╚█║██╔════╝
        ██████╔╝█████╗░░███████║██║░░██║█████╗░░██████╔╝░╚╝╚█████╗░
        ██╔══██╗██╔══╝░░██╔══██║██║░░██║██╔══╝░░██╔══██╗░░░░╚═══██╗
        ██║░░██║███████╗██║░░██║██████╔╝███████╗██║░░██║░░░██████╔╝
        ╚═╝░░╚═╝╚══════╝╚═╝░░╚═╝╚═════╝░╚══════╝╚═╝░░╚═╝░░░╚═════╝░
                ██████╗░███████╗░█████╗░██╗░░░░░███╗░░░███╗         
                ██╔══██╗██╔════╝██╔══██╗██║░░░░░████╗░████║
                ██████╔╝█████╗░░███████║██║░░░░░██╔████╔██║
                ██╔══██╗██╔══╝░░██╔══██║██║░░░░░██║╚██╔╝██║
                ██║░░██║███████╗██║░░██║███████╗██║░╚═╝░██║
                ╚═╝░░╚═╝╚══════╝╚═╝░░╚═╝╚══════╝╚═╝░░░░░╚═╝

    ");

    }

    public static void ShowWelcomeMessage()
    {
        Console.WriteLine("Helping you to find and share book reviews ;)");
        Console.WriteLine("\nPress any key to continue...");
        Console.ReadKey();
    }

    public static void ShowOptionsMenu()
    {
        Console.Clear();
        ShowTitle();
        Console.WriteLine("\n\nType 1 to register a new book");
        Console.WriteLine("Type 2 to rate a book");
        Console.WriteLine("Type 3 to see all registered books and their average rating");
        Console.WriteLine("\ntype -1 to exit");

        Console.Write("\nType the number realated to the option: ");
        string chosenOption = Console.ReadLine()!;
        int chosenOptionNumber = int.Parse(chosenOption);
        switch (chosenOptionNumber)
        {

            case 1:
                LibraryManager.RegisterBook();
                break;
            case 2:
                LibraryManager.AddRatingToBook();
                break;
            case 3:
                LibraryManager.ShowAllBooks();
                break;
            case -1:
                Console.WriteLine("Exiting...");
                break;
            default:
                Console.WriteLine("Ivalid option...");
                Thread.Sleep(2000);
                ShowOptionsMenu();
                break;

        }

    }


}
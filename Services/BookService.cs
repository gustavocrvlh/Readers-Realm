public class BookService
{
    private readonly LibraryContext _context;

    public BookService()
    {
        _context = new LibraryContext();
    }

    public void AddBook(string bookName, string author)
    {
        var book = new Book { Name = bookName, Author = author };
        _context.Books.Add(book);
        _context.SaveChanges();
    }

    public void AddRating(int bookId, int rating)
    {
        var book = _context.Books.FirstOrDefault(b => b.Id == bookId);
        if (book != null)
        {
            book.Ratings.Add(rating);
            _context.SaveChanges();
        }
        else
        {
            Console.WriteLine($"Book with ID {bookId} not found.");
        }
    }

    public List<Book> GetAllBooks()
    {
        return _context.Books.ToList();
    }
}
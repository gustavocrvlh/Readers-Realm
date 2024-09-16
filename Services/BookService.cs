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

    public List<Book> GetAllBooks()
    {
        return _context.Books.ToList();
    }
}
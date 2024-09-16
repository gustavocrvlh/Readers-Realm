using Microsoft.EntityFrameworkCore;

public class LibraryContext : DbContext
{
    public DbSet<Book> Books { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var folderPath = Path.Combine(Environment.CurrentDirectory, "Database");
        if (!Directory.Exists(folderPath))
        {
            Directory.CreateDirectory(folderPath); // Cria a pasta se ela não existir
        }
        var dbPath = Path.Combine(folderPath, "library.db");
        optionsBuilder.UseSqlite($"Data Source={dbPath}");
    }
}
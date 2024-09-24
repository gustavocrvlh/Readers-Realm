using System.ComponentModel.DataAnnotations;

public class Book
{
    [Key]
    public int Id { get; set; }
    public required string Name { get; set; }
    public required string Author { get; set; }
    public List<int> Ratings { get; set; } = new List<int>();
    public double AverageRating
    {
        get
        {
            return Ratings.Count > 0 ? Ratings.Average() : 0;
        }
    }
}
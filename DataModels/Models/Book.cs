namespace DataModels.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public virtual List<Genre> Genres { get; set; } = new List<Genre>();
        public string? Author { get; set; }
        public int? Rating { get; set; }
        public string? Publisher { get; set; }
        public int Year { get; set; }
    }
}

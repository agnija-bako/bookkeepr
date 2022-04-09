namespace DataModels.Models
{
    public class User
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public virtual List<Library> Libraries { get; set; } = new List<Library>();
    }
}

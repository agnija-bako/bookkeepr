namespace DataModels.Models
{
    public class Library
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public virtual List<Purchase> Purchases { get; set; } = new List<Purchase>();
    }
}

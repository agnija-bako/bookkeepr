namespace DataModels.Models
{
    public class Purchase
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double Price { get; set; }
        public int UserId { get; set; }
        public int BookId { get; set; }
    }
}

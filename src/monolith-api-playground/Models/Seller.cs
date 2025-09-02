namespace monolith_api_playground.Models
{
    public class Seller
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime RegisteredDate { get; set; }
    }
}

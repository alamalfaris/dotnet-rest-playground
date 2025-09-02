namespace monolith_api_playground.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int ProductCategoryId { get; set; }
        public int SellerId { get; set; }
        public DateTime PublishedDate { get; set; }
    }
}

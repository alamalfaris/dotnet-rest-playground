using monolith_api_playground.Models;

namespace monolith_api_playground.Repositories
{
    public class ProductRepo
    {
        private static readonly List<Product> _products = new List<Product>
        {
            new Product
            {
                Id = 1,
                Name = "Iphone 16",
                ProductCategoryId = 1,
                SellerId = 1,
                PublishedDate = DateTime.Now
            },
            new Product
            {
                Id = 2,
                Name = "Kemeja Flannel Lengan Panjang",
                ProductCategoryId = 2,
                SellerId = 2,
                PublishedDate = DateTime.Now
            },
            new Product
            {
                Id = 3,
                Name = "Masker Wajah Himalaya",
                ProductCategoryId = 3,
                SellerId = 3,
                PublishedDate = DateTime.Now
            },
            new Product
            {
                Id = 4,
                Name = "Samsung Galaxy S25",
                ProductCategoryId = 1,
                SellerId = 1,
                PublishedDate = DateTime.Now
            },
        };
    }
}

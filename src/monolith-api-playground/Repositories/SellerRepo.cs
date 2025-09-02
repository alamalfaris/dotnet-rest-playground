using monolith_api_playground.Models;

namespace monolith_api_playground.Repositories
{
    public class SellerRepo
    {
        private static readonly List<Seller> _sellers = new List<Seller>
        {
            new Seller
            {
                Id = 1,
                Name = "iBox",
                Description = "Apple authorized reseller",
                RegisteredDate = new DateTime(2025,1,1)
            },
            new Seller
            {
                Id = 2,
                Name = "Gaya Fashion",
                Description = "Jual pakaian trendy",
                RegisteredDate = new DateTime(2025,1,2)
            },
            new Seller
            {
                Id = 3,
                Name = "Guardian Official Store",
                Description = "Guardian Official Store",
                RegisteredDate = new DateTime(2025,1,1)
            }
        };
    }
}

using monolith_api_playground.Models;

namespace monolith_api_playground.Repositories
{
    public class ProductCategoryRepo
    {
        private static readonly List<ProductCategory> _productCategories = new List<ProductCategory>
        {
            new ProductCategory
            {
                Id = 1,
                Name = "Electronic and Gadget"
            },
            new ProductCategory
            {
                Id = 2,
                Name = "Fashion"
            },
            new ProductCategory
            {
                Id = 3,
                Name = "Kecantikan dan Perawatan Diri"
            }
        };
    }
}

using Rm_Assignment_10.Models;

namespace Rm_Assignment_10.Repository
{
    public interface IProductRepository
    {
        void AddProduct(Product product);
        string ModifyProduct(Product product);
        string DeleteProduct(int id);
        Product GetProductByIdorName(int? productId, string? productName);
        List<Product> GetProductByCategory(string Category);
    }
}

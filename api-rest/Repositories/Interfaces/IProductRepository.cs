using api_rest.models;

namespace api_rest.Repositories.Interfaces
{
    public interface IProductRepository
    {
        Task<ProductModel> AddProduct(ProductModel Product);
        Task<List<ProductModel>> GetAllProducts();
        Task<ProductModel> GetProductById(int id);
        Task<ProductModel> UpdateProduct(ProductModel Product, int id);
        Task<bool> DeleteProduct(int id);
    }
}

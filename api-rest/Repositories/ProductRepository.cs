using api_rest.Data;
using api_rest.models;
using api_rest.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace api_rest.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly EcommerceSystemDbContext _dbContext;
        public ProductRepository(EcommerceSystemDbContext EcommerceSystemDbContext)
        {
            _dbContext = EcommerceSystemDbContext;
        }

        // Método de adicionar Produto
        public async Task<ProductModel> AddProduct(ProductModel Product)
        {
            await _dbContext.Products.AddAsync(Product);
            await _dbContext.SaveChangesAsync();

            return Product;
        }

        // Método para Listar todos os produtos
        public async Task<List<ProductModel>> GetAllProducts()
        {
            return await _dbContext.Products.ToListAsync();
        }

        // Método para pegar um produto por ID
        public async Task<ProductModel> GetProductById(int id)
        {
            return await _dbContext.Products.FirstOrDefaultAsync(x => x.Id == id);
        }

        // Método para atualizar um produto
        public async Task<ProductModel> UpdateProduct(ProductModel Product, int id)
        {
            ProductModel productById = await GetProductById(id);
            if(productById == null)
            {
                throw new Exception($"Usuário para o ID: {id} não foi encontrado no Banco de Dados.");
            }

            // Elementos que serão atualizados
            productById.ProductName = Product.ProductName;
            productById.ProductDescription = Product.ProductDescription;
            productById.ProductPrice = Product.ProductPrice;
            productById.ProductImage = Product.ProductImage;
            productById.ProductSize = Product.ProductSize;
            productById.ProductColor= Product.ProductColor;
            productById.ProductDetails = Product.ProductDetails;


            _dbContext.Products.Update(productById);
            await _dbContext.SaveChangesAsync();

            return productById;
        }

        // Método para deletar um produto
        public async Task<bool> DeleteProduct(int id)
        {
            ProductModel productById = await GetProductById(id);

            if (productById == null)
            {
                throw new Exception($"Usuário para o ID: {id} não foi encontrado no Banco de Dados.");
            }

            // Remove permanentemente do Banco de dados
            _dbContext.Products.Remove(productById);
            await _dbContext.SaveChangesAsync();
            return true;
        }
    }
}

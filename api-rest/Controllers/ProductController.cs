using api_rest.models;
using api_rest.Repositories.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace api_rest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }


        // Método para criar um produto
        [HttpPost]
        public async Task<ActionResult<List<ProductModel>>> AddProduct([FromBody] ProductModel productModel)
        {
            ProductModel product = await _productRepository.AddProduct(productModel);
            return Ok(product);
        }


        // Trecho do endpoint que pega todos os produtos
        [HttpGet]
        public async Task<ActionResult<List<ProductModel>>> GetAllProducts()
        {
            List<ProductModel> products = await _productRepository.GetAllProducts();
            return Ok(products);
        }

        // Comando do endpoint que pega o produto por id
        [HttpGet("{Id}")]
        public async Task<ActionResult<ProductModel>> GetProductById(int Id)
        {
            ProductModel product = await _productRepository.GetProductById(Id);
            return Ok(product);
        }

        // Comando do endpoint que atualiza o produto
        [HttpPut("{Id}")]
        public async Task<ActionResult<List<ProductModel>>> UpdateProduct([FromBody] ProductModel productModel, int Id)
        {
            productModel.Id = Id;
            ProductModel product = await _productRepository.UpdateProduct(productModel, Id);
            return Ok(product);
        }

        // Comando do endpoint que atualiza o produto
        [HttpDelete("{Id}")]
        public async Task<ActionResult<List<ProductModel>>> DeleteProduct(int Id)
        {
            bool deleted = await _productRepository.DeleteProduct(Id);
            return Ok(deleted);
        }

    }
}

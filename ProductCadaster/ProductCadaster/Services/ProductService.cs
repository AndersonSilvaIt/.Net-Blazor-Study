using ProductCadaster.Data;
using ProductCadaster.Models;

namespace ProductCadaster.Services
{
    public class ProductService : IProductService
    {
        private readonly ProductRepository _repository;

        public ProductService(ProductRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<Product>> GetAllProductsAsync() => await _repository.GetAllProductsAsync();
        public async Task<Product> GetProductByIdAsync(int id) => await _repository.GetProductByIdAsync(id);
        public async Task AddProductAsync(Product product) => await _repository.AddProductAsync(product);
        public async Task UpdateProductAsync(Product product) => await _repository.UpdateProductAsync(product);
        public async Task DeleteProductAsync(int id) => await _repository.DeleteProductAsync(id);
    }
}

using PetStore.Models;
using PetStore.Repositories.Interfaces;
using PetStore.Services.Interfaces;

namespace PetStore.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repository;

        public ProductService(IProductRepository repository)
        {
            _repository = repository;
        }


        public Product? GetProductById(string id)
        {
            if (string.IsNullOrEmpty(id))
                throw new ArgumentNullException(nameof(id), "The id can not be null");

            if (!int.TryParse(id, out var productId))
                throw new ArgumentException("{0} is not a valid id", id);

            var bp = _repository.GetById(productId);
            return _repository.GetById(productId);
        }

        public IEnumerable<Product> GetProducts()
        {
            return _repository.GetAll();
        }
    }
}

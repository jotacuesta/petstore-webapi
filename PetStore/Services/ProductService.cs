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


        public Product GetProductById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetProducts()
        {
            return _repository.GetAll();
        }
    }
}

using PetStore.Models;

namespace PetStore.Services.Interfaces
{
    public interface IProductService
    {
        public IEnumerable<Product> GetProducts();

        public Product? GetProductById(string id);
    }
}

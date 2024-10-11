using PetStore.Models;

namespace PetStore.Repositories.Interfaces
{
    public interface IProductRepository
    {
        public IEnumerable<Product> GetAll();

        public Product? GetById(int id);
    }
}

using System.Xml.Linq;

namespace PetStore.Models
{
    public struct Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public decimal? Price { get; set; }

        public ProductCategory Category { get; set; }

        public int Quantity { get; set; }

        public Product()
        {
            Id = -1;
            Name = string.Empty;
            Description = string.Empty;
            Price = 0;
            Category = ProductCategory.Food;
            Quantity = 0;
        }

        public Product(int id, string name, string description, decimal? price, ProductCategory category, int quantity)
        {
            Id = id;
            Name = name;
            Description = description;
            Price = price;
            Category = category;
            Quantity = quantity;
        }
    }
}

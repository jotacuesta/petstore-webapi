using Moq;
using PetStore.Models;
using PetStore.Repositories.Interfaces;
using PetStore.Services;
using PetStore.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStoreTests.Services
{
    [TestFixture]
    public class ProductServiceTest
    {
        private IProductService _productService;
        private Mock<IProductRepository> _productRepository;

        [SetUp]
        public void Init()
        {
            _productRepository = new Mock<IProductRepository>();

            _productRepository.Setup(x => x.GetAll())
                .Returns(mock_products);


            _productService = new ProductService(_productRepository.Object);
        }

        [Test]
        public void GetProducts_Always_ReturnProducts()
        {
            var products = _productService.GetProducts();
            Assert.That(products.Any(), Is.True);          
        }

        private IEnumerable<Product> mock_products()
        {
            List<Product> products = new()
            {
                // Food Category
                new Product(1, "Premium Dog Food", "High-quality dry dog food.", 45.99m, ProductCategory.Food, 50),
                new Product(2, "Wet Cat Food", "Tasty wet food for adult cats.", 2.50m, ProductCategory.Food, 200),
                new Product(3, "Hamster Food Mix", "Balanced mix for hamsters.", 10.99m, ProductCategory.Food, 100),

                // Hygiene and Beauty Category
                new Product(4, "Pet Shampoo", "Gentle shampoo for all breeds.", 12.99m, ProductCategory.HygieneAndBeauty, 75),
                new Product(5, "Cat Grooming Kit", "Complete kit for cat grooming.", 25.00m, ProductCategory.HygieneAndBeauty, 30),
                new Product(6, "Nail Clippers", "Clippers for trimming pet nails.", 8.50m, ProductCategory.HygieneAndBeauty, 120),

                // Toys Category
                new Product(7, "Rubber Ball", "Durable rubber ball for dogs.", 4.99m, ProductCategory.Toys, 150),
                new Product(8, "Cat Teaser Wand", "Interactive toy for cats.", 7.99m, ProductCategory.Toys, 90),
                new Product(9, "Squeaky Toy", "Fun squeaky toy for puppies.", 6.99m, ProductCategory.Toys, 110),

                // Accessories Category
                new Product(10, "Adjustable Dog Leash", "Comfortable leash for dogs.", 15.99m, ProductCategory.Accessories, 60),
                new Product(11, "Pet Carrier", "Compact carrier for small pets.", 59.99m, ProductCategory.Accessories, 25),
                new Product(12, "Water Dispenser", "Automatic water dispenser for pets.", 29.99m, ProductCategory.Accessories, 40),

                // Health and Wellness Category
                new Product(13, "Flea Treatment", "Effective flea and tick treatment.", 19.99m, ProductCategory.HealthAndWellness, 80),
                new Product(14, "Multivitamins for Dogs", "Daily vitamins for dog health.", 22.50m, ProductCategory.HealthAndWellness, 50),
                new Product(15, "Joint Support Supplement", "Helps support joint health in pets.", 35.00m, ProductCategory.HealthAndWellness, 35)
            };
            return products;
        }
    }
}

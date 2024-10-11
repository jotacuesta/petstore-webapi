using Microsoft.AspNetCore.Mvc;
using PetStore.Services.Interfaces;

namespace PetStore.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
    }
}

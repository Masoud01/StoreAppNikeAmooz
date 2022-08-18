using AspStore.ShopUi.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspStore.ShopUi.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductRepository _prodyctRepository;
        public HomeController(IProductRepository productRepository)
        {
            _prodyctRepository = productRepository;
        }
        public IActionResult Index()
        {
            return View(_prodyctRepository.GetAll());
        }
    }
}

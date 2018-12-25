using Microsoft.AspNetCore.Mvc;
using ShoesStore.DAL.Interfaces;
using System.Linq;

namespace ShoesStore.Controllers
{
    [Route("")]
    public class CatalogController : Controller
    {
        private readonly IProductRepository repository;

        public CatalogController(IProductRepository repository)
        {
            this.repository = repository;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(repository.Products.Where(p => p.IsActive));
        }
    }
}
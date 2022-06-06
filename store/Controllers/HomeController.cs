using Microsoft.AspNetCore.Mvc;
using store.Models;
namespace store.Controllers
{
    public class HomeController : Controller
    {
        private IStoreRepository repository;

        public HomeController(IStoreRepository repo)
        {
            repository = repo;
        }


        public IActionResult index() => View(repository.Products);
    }
}

using Microsoft.AspNetCore.Mvc;
using store.Models;
using System.Linq;
namespace store.Controllers

{
    public class HomeController : Controller
    {
        private IStoreRepository repository;
        public int pageSize = 4;

        public HomeController(IStoreRepository repo)
        {
            repository = repo;
        }


        public IActionResult index(int productPage = 1)
           => View(repository.Products.OrderBy(p => p.ProductID)
                .Skip((productPage - 1) * pageSize)
                .Take(pageSize)); 
        
    }
}

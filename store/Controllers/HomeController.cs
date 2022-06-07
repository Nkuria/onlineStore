using Microsoft.AspNetCore.Mvc;
using store.Models;
using System.Linq;
using store.Models.ViewModels;
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

        public ViewResult Index(int productPage = 1)
            => View(new ProductsListViewModel
            {
                Products = repository.Products
                .OrderBy(p => p.ProductID)
                .Skip((productPage - 1) * pageSize)
                .Take(pageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = productPage,
                    ItemsPerPage = pageSize,
                    TotalItems = repository.Products.Count()
                }
            });




    }
}


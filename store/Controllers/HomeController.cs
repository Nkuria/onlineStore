using Microsoft.AspNetCore.Mvc;
namespace store.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult index() => View();
    }
}

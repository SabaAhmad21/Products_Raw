using Microsoft.AspNetCore.Mvc;

namespace RawMaterial.Controllers
{
    public class MaterialController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Materials()
        {
            return View();
        }

        public IActionResult MaterialCreateVM()
        {
            return View();
        }
        
    }
}

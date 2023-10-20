using Microsoft.AspNetCore.Mvc;

namespace Projeto.Areas.Admin.Controllers
{
   
        public class AdminController : Controller{
            [Area("Admin")]
            public IActionResult Index()
            {
                return View();
            }
    }
}
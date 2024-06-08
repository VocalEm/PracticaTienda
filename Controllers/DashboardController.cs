using Data;
using Microsoft.AspNetCore.Mvc;

namespace PracticaTienda.Controllers
{
    public class DashboardController : BaseController
    {
       public DashboardController(ApplicationDbContext context): base(context)
       { }
        public IActionResult Index()
        {
            return View();
        }
    }
}
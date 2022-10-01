using Clinic.DataAccess.Data;
using Microsoft.AspNetCore.Mvc;

namespace Clinic.WebAdmin.Controllers
{
    public class HomeController : Controller
    {
        private readonly ClinicContext _context;

        public HomeController(ClinicContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
using Clinic.DataAccess.Data;
using Microsoft.AspNetCore.Mvc;

namespace Clinic.WebPatient.Controllers
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
            ViewBag.ModelMenu =
                (
                    from page in _context.Page
                    where page.IsActive == true
                    orderby page.PageLinkPosition
                    select page
                ).ToList();

            ViewBag.ModelDoctor =
                (
                    from doctor in _context.Doctor
                    where doctor.IsActive == true
                    orderby doctor.Position
                    select doctor
                ).ToList();

            ViewBag.ModelParameter =
                (
                    from parameter in _context.Parameter
                    where parameter.IsActive == true
                    select parameter
                ).ToList();

            return View();
        }
    }
}
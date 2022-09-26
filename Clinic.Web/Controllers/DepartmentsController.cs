using Clinic.Database.Data;
using Microsoft.AspNetCore.Mvc;

namespace Clinic.Web.Controllers
{
    public class DepartmentsController : Controller
    {
        private readonly ClinicContext _context;

        public DepartmentsController(ClinicContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            ViewBag.ModelMenu =
               ViewBag.ModelMenu =
                (
                    from page in _context.Page
                    where page.IsActive == true
                    orderby page.PageLinkPosition
                    select page
                ).ToList();

            return View();
        }
    }
}

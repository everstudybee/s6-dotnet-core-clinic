using Clinic.Database.Data;
using Microsoft.AspNetCore.Mvc;

namespace Clinic.Web.Controllers
{
    public class ServicesController : Controller
    {
        private readonly ClinicContext _context;

        public ServicesController(ClinicContext context)
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

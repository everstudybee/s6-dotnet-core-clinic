using Clinic.DataAccess.Data;
using Microsoft.AspNetCore.Mvc;

namespace Clinic.WebPatient.Controllers;

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

        ViewBag.ModelParameter =
            (
                from parameter in _context.Parameter
                where parameter.IsActive == true
                select parameter
            ).ToList();

        return View();
    }
}

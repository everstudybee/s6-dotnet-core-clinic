using Clinic.DataAccess.Data;
using Microsoft.AspNetCore.Mvc;

namespace Clinic.WebPatient.Controllers;

public class DoctorsController : Controller
{
    private readonly ClinicContext _context;

    public DoctorsController(ClinicContext context)
    {
        _context = context;
    }

    public IActionResult Index(int? id)
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

        if(id == null)
        {
            return View();
        }

        var pageId = _context.Doctor?.Find(id);

        return View(pageId);
    }
}

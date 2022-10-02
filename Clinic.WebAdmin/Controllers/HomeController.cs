using Clinic.DataAccess.Data;
using Clinic.Logic.WebAdmin;
using Clinic.WebAdmin.Models.Dashboard;
using Microsoft.AspNetCore.Mvc;

namespace Clinic.WebAdmin.Controllers;

public class HomeController : Controller
{
    private readonly ClinicContext _context;

    public HomeController(ClinicContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        var dashboardTotals = new DashboardTotals(_context);

        var dashboardSummary = new DashboardSummary()
        {
            TotalParameters = await dashboardTotals.GetTotalParameters(),
            TotalPages = await dashboardTotals.GetTotalPages(),
            TotalDoctors = await dashboardTotals.GetTotalDoctors(),
            TotalServices = await dashboardTotals.GetTotalServices(),
        };

        return View(dashboardSummary);
    }
}
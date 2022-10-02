using Clinic.DataAccess.Data;
using Microsoft.EntityFrameworkCore;

namespace Clinic.Logic.WebAdmin;
public class DashboardTotals
{
    private readonly ClinicContext _context;

    public DashboardTotals(ClinicContext context)
    {
        _context = context;
    }

    public async Task<int> GetTotalParameters()
    {
        var items =
            (
                from element in _context.Parameter
                select element
            );

        //zwraca wartość koszyka
        return await items.CountAsync();
    }
    public async Task<int> GetTotalPages()
    {
        var items =
            (
                from element in _context.Page
                select element
            );

        //zwraca wartość koszyka
        return await items.CountAsync();
    }

    public async Task<int> GetTotalDoctors()
    {
        var items =
            (
                from element in _context.Doctor
                select element
            );

        //zwraca wartość koszyka
        return await items.CountAsync();
    }

    public async Task<int> GetTotalServices()
    {
        var items =
            (
                from element in _context.Service
                select element
            );

        //zwraca wartość koszyka
        return await items.CountAsync();
    }
}

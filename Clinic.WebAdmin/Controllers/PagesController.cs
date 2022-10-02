using Clinic.DataAccess.Data;
using Clinic.Entities.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Clinic.WebAdmin.Controllers;

public class PagesController : Controller
{
    private readonly ClinicContext _context;

    public PagesController(ClinicContext context)
    {
        _context = context;
    }

    // GET: Pages
    public async Task<IActionResult> Index()
    {
        return View(await _context.Page.ToListAsync());
    }

    // GET: Pages/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: Pages/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("PageId,PageAnchorText,PageLink,PageLinkPosition,WhoAdded,WhenAdded,WhoModified,WhenModified,WhoRemoved,WhenRemoved,IsActive")] Page page)
    {
        if(ModelState.IsValid)
        {
            _context.Add(page);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(page);
    }

    // GET: Pages/Edit/5
    public async Task<IActionResult> Edit(int? id)
    {
        if(id == null || _context.Page == null)
        {
            return NotFound();
        }

        var page = await _context.Page.FindAsync(id);
        if(page == null)
        {
            return NotFound();
        }
        return View(page);
    }

    // POST: Pages/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int id, [Bind("PageId,PageAnchorText,PageLink,PageLinkPosition,WhoAdded,WhenAdded,WhoModified,WhenModified,WhoRemoved,WhenRemoved,IsActive")] Page page)
    {
        if(id != page.PageId)
        {
            return NotFound();
        }

        if(ModelState.IsValid)
        {
            try
            {
                _context.Update(page);
                await _context.SaveChangesAsync();
            }
            catch(DbUpdateConcurrencyException)
            {
                if(!PageExists(page.PageId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return RedirectToAction(nameof(Index));
        }
        return View(page);
    }

    // GET: Pages/Delete/5
    public async Task<IActionResult> Delete(int? id)
    {
        if(id == null || _context.Page == null)
        {
            return NotFound();
        }

        var page = await _context.Page
            .FirstOrDefaultAsync(m => m.PageId == id);
        if(page == null)
        {
            return NotFound();
        }

        return View(page);
    }

    // POST: Pages/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        if(_context.Page == null)
        {
            return Problem("Entity set 'ClinicContext.Page'  is null.");
        }
        var page = await _context.Page.FindAsync(id);
        if(page != null)
        {
            _context.Page.Remove(page);
        }

        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool PageExists(int id)
    {
        return _context.Page.Any(e => e.PageId == id);
    }
}

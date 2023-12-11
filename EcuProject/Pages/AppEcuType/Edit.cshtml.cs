using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace EcuProject.Pages.AppEcuType
{
    using EcuProject.Data;
    using EcuProject.Model;

    public class EditModel : PageModel
    {
        private readonly EcuProject.Data.EcuContext _context;

        public EditModel(EcuProject.Data.EcuContext context)
        {
            _context = context;
        }

        [BindProperty]
        public AppEcuType AppEcuType { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var appecutype = await _context.AppEcuType.FirstOrDefaultAsync(m => m.Id == id);
            if (appecutype == null)
            {
                return NotFound();
            }
            AppEcuType = appecutype;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(AppEcuType).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AppEcuTypeExists(AppEcuType.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool AppEcuTypeExists(int id)
        {
            return _context.AppEcuType.Any(e => e.Id == id);
        }
    }
}

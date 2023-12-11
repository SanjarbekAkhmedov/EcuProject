using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EcuProject.Data;
using EcuProject.Model;

namespace EcuProject.Pages.CarMarker
{
    public class EditModel : PageModel
    {
        private readonly EcuProject.Data.EcuContext _context;

        public EditModel(EcuProject.Data.EcuContext context)
        {
            _context = context;
        }

        [BindProperty]
        public AppCarmaker AppCarmaker { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var appcarmaker =  await _context.AppCarmaker.FirstOrDefaultAsync(m => m.Id == id);
            if (appcarmaker == null)
            {
                return NotFound();
            }
            AppCarmaker = appcarmaker;
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

            _context.Attach(AppCarmaker).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AppCarmakerExists(AppCarmaker.Id))
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

        private bool AppCarmakerExists(int id)
        {
            return _context.AppCarmaker.Any(e => e.Id == id);
        }
    }
}

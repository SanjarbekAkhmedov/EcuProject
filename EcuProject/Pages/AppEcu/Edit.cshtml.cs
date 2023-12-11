using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace EcuProject.Pages.AppEcu
{
    using EcuProject.Model;

    public class EditModel : PageModel
    {
        private readonly EcuProject.Data.EcuContext _context;

        public EditModel(EcuProject.Data.EcuContext context)
        {
            _context = context;
        }

        [BindProperty]
        public AppEcu AppEcu { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var appecu =  await _context.AppEcu.FirstOrDefaultAsync(m => m.Id == id);
            if (appecu == null)
            {
                return NotFound();
            }
            AppEcu = appecu;
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

            _context.Attach(AppEcu).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AppEcuExists(AppEcu.Id))
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

        private bool AppEcuExists(int id)
        {
            return _context.AppEcu.Any(e => e.Id == id);
        }
    }
}

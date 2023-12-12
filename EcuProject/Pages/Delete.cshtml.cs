using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace EcuProject.Pages.AppEcu
{
    using EcuProject.Model;

    public class DeleteModel : PageModel
    {
        private readonly EcuProject.Data.B29838evEcubaseContext _context;

        public DeleteModel(EcuProject.Data.B29838evEcubaseContext context)
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

            var appecu = await _context.AppEcus.FirstOrDefaultAsync(m => m.Id == id);

            if (appecu == null)
            {
                return NotFound();
            }
            else
            {
                AppEcu = appecu;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var appecu = await _context.AppEcus.FindAsync(id);
            if (appecu != null)
            {
                AppEcu = appecu;
                _context.AppEcus.Remove(AppEcu);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}

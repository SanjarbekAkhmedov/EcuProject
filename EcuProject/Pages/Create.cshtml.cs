using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EcuProject.Pages.AppEcu
{
    using EcuProject.Model;

    public class CreateModel : PageModel
    {
        private readonly EcuProject.Data.B29838evEcubaseContext _context;

        public CreateModel(EcuProject.Data.B29838evEcubaseContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public AppEcu AppEcu { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.AppEcus.Add(AppEcu);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}

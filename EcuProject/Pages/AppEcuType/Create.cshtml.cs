using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EcuProject.Pages.AppEcuType
{
    using EcuProject.Data;
    using EcuProject.Model;

    public class CreateModel : PageModel
    {
        private readonly EcuProject.Data.EcuContext _context;

        public CreateModel(EcuProject.Data.EcuContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public AppEcuType AppEcuType { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.AppEcuType.Add(AppEcuType);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}

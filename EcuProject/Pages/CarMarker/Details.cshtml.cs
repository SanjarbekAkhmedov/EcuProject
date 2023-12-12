using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EcuProject.Data;
using EcuProject.Model;

namespace EcuProject.Pages.CarMarker
{
    public class DetailsModel : PageModel
    {
        private readonly EcuProject.Data.B29838evEcubaseContext _context;

        public DetailsModel(EcuProject.Data.B29838evEcubaseContext context)
        {
            _context = context;
        }

        public AppCarmaker AppCarmaker { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var appcarmaker = await _context.AppCarmakers.FirstOrDefaultAsync(m => m.Id == id);
            if (appcarmaker == null)
            {
                return NotFound();
            }
            else
            {
                AppCarmaker = appcarmaker;
            }
            return Page();
        }
    }
}

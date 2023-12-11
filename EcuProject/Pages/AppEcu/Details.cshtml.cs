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

    public class DetailsModel : PageModel
    {
        private readonly EcuProject.Data.EcuContext _context;

        public DetailsModel(EcuProject.Data.EcuContext context)
        {
            _context = context;
        }

        public AppEcu AppEcu { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var appecu = await _context.AppEcu.FirstOrDefaultAsync(m => m.Id == id);
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
    }
}

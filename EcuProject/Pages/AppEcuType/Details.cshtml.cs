using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace EcuProject.Pages.AppEcuType
{
    using EcuProject.Data;
    using EcuProject.Model;

    public class DetailsModel : PageModel
    {
        private readonly EcuProject.Data.B29838evEcubaseContext _context;

        public DetailsModel(EcuProject.Data.B29838evEcubaseContext context)
        {
            _context = context;
        }

        public AppEcuType AppEcuType { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var appecutype = await _context.AppEcuTypes.FirstOrDefaultAsync(m => m.Id == id);
            if (appecutype == null)
            {
                return NotFound();
            }
            else
            {
                AppEcuType = appecutype;
            }
            return Page();
        }
    }
}

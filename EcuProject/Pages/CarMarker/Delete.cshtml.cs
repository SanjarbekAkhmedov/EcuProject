﻿using System;
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
    public class DeleteModel : PageModel
    {
        private readonly EcuProject.Data.B29838evEcubaseContext _context;

        public DeleteModel(EcuProject.Data.B29838evEcubaseContext context)
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var appcarmaker = await _context.AppCarmakers.FindAsync(id);
            if (appcarmaker != null)
            {
                AppCarmaker = appcarmaker;
                _context.AppCarmakers.Remove(AppCarmaker);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}

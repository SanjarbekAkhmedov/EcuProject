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

    public class IndexModel : PageModel
    {
        private readonly EcuProject.Data.EcuContext _context;

        public IndexModel(EcuProject.Data.EcuContext context)
        {
            _context = context;
        }

        public IList<AppEcuType> AppEcuType { get;set; } = default!;

        public async Task OnGetAsync()
        {
            AppEcuType = await _context.AppEcuType.ToListAsync();
        }
    }
}

using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EcuProject.Data;
using EcuProject.Model;

namespace EcuProject.Pages.CarMarker
{
    public class IndexModel : PageModel
    {
        private readonly EcuContext _context;

        public IndexModel(EcuContext context)
        {
            _context = context;
        }

        public IList<AppCarmaker> AppCarmaker { get; set; } = default!;

        public async Task OnGetAsync()
        {
            AppCarmaker = await _context.AppCarmaker.ToListAsync();
        }
    }
}

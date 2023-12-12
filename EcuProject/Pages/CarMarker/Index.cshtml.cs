using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EcuProject.Data;
using EcuProject.Model;

namespace EcuProject.Pages.CarMarker
{
    public class IndexModel : PageModel
    {
        private readonly B29838evEcubaseContext _context;

        public IndexModel(B29838evEcubaseContext context)
        {
            _context = context;
        }

        public IList<AppCarmaker> AppCarmaker { get; set; } = default!;

        public async Task OnGetAsync()
        {
            AppCarmaker = await _context.AppCarmakers.ToListAsync();
        }
    }
}

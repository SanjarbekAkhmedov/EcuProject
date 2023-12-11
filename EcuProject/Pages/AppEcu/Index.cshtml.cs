using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace EcuProject.Pages.AppEcu
{
    using EcuProject.Model;

    public class IndexModel : PageModel
    {
        private readonly EcuProject.Data.EcuContext _context;

        public IndexModel(EcuProject.Data.EcuContext context)
        {
            _context = context;
        }

        public IList<AppEcu> AppEcu { get; set; } = new List<AppEcu>();


        public IList<AppEcuType> AppEcuTypes { get; set; } = new List<AppEcuType>();

        [BindProperty(SupportsGet = true)]
        public int SelectedEcuTypeId { get; set; }

        public IList<AppCarmaker> AppCarmakers { get; set; } = new List<AppCarmaker>();

        [BindProperty(SupportsGet = true)]
        public int SelectedCarmakerId { get; set; }

        public IList<AppEcuProducer> AppEcuProducers { get; set; } = new List<AppEcuProducer>();

        [BindProperty(SupportsGet = true)]
        public int SelectedEcuProducerId { get; set; }

        public async Task OnGetAsync()
        {
            AppCarmakers = await _context.AppCarmaker.ToListAsync();
            AppEcuTypes = await _context.AppEcuType.ToListAsync();
            AppEcuProducers = await _context.AppEcuProducer.ToListAsync();

            IQueryable<AppEcu> ecuQuery = _context.AppEcu.AsQueryable();

            if (SelectedEcuTypeId > 0)
            {
                ecuQuery = ecuQuery.Where(e => e.EcuType == SelectedEcuTypeId);
            }
            if (SelectedCarmakerId > 0)
            {
                ecuQuery = ecuQuery.Where(e => e.Carmaker == SelectedCarmakerId);
            }
            if (SelectedEcuProducerId > 0)
            {
                ecuQuery = ecuQuery.Where(e => e.EcuProducer == SelectedEcuProducerId);
            }

            AppEcu = await ecuQuery.ToListAsync();
        }
    }

}

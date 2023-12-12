using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace EcuProject.Pages.AppEcu
{
    using EcuProject.Model;

    public class IndexModel : PageModel
    {
        private readonly EcuProject.Data.B29838evEcubaseContext _context;

        public IndexModel(EcuProject.Data.B29838evEcubaseContext context)
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

        public List<BaseEntity> GetTable(string tableName)
        {
            tableName = GetEntityName(tableName);
            if (string.IsNullOrEmpty(tableName))
                return null;

            var baseEntities = new List<BaseEntity>();

            switch (tableName)
            {
                case nameof(AppEcuAcdelco):
                    baseEntities.AddRange(_context.Set<AppEcuAcdelco>().Cast<BaseEntity>());
                    break;
                case nameof(AppEcuBosch):
                    baseEntities.AddRange(_context.Set<AppEcuBosch>().Cast<BaseEntity>());
                    break;
                case nameof(AppEcuDelphi):
                    baseEntities.AddRange(_context.Set<AppEcuDelphi>().Cast<BaseEntity>());
                    break;
                case nameof(AppEcuDenso):
                    baseEntities.AddRange(_context.Set<AppEcuDenso>().Cast<BaseEntity>());
                    break;
                case nameof(AppEcuHitachi):
                    baseEntities.AddRange(_context.Set<AppEcuHitachi>().Cast<BaseEntity>());
                    break;
                case nameof(AppEcuKefico):
                    baseEntities.AddRange(_context.Set<AppEcuKefico>().Cast<BaseEntity>());
                    break;
                case nameof(AppEcuKeihin):
                    baseEntities.AddRange(_context.Set<AppEcuKeihin>().Cast<BaseEntity>());
                    break;
                case nameof(AppEcuLuca):
                    baseEntities.AddRange(_context.Set<AppEcuLuca>().Cast<BaseEntity>());
                    break;
                case nameof(AppEcuMagneti):
                    baseEntities.AddRange(_context.Set<AppEcuMagneti>().Cast<BaseEntity>());
                    break;
                case nameof(AppEcuSagem):
                    baseEntities.AddRange(_context.Set<AppEcuSagem>().Cast<BaseEntity>());
                    break;
                case "AppEcuSiemens":
                    baseEntities.AddRange(_context.Set<AppEcuSiemen>().Cast<BaseEntity>());
                    break;
                case nameof(AppEcuTemic):
                    baseEntities.AddRange(_context.Set<AppEcuTemic>().Cast<BaseEntity>());
                    break;
                case nameof(AppEcuTranstron):
                    baseEntities.AddRange(_context.Set<AppEcuTranstron>().Cast<BaseEntity>());
                    break;
                case nameof(AppEcuTrw):
                    baseEntities.AddRange(_context.Set<AppEcuTrw>().Cast<BaseEntity>());
                    break;
                case nameof(AppEcuValeo):
                    baseEntities.AddRange(_context.Set<AppEcuValeo>().Cast<BaseEntity>());
                    break;
                case nameof(AppEcuVisteon):
                    baseEntities.AddRange(_context.Set<AppEcuVisteon>().Cast<BaseEntity>());
                    break;
                default:
                    // Handle the case when tableName doesn't match any known entity
                    break;
            }

            return baseEntities;
        }


        public string GetEntityName(string text)
        {
            if (string.IsNullOrEmpty(text))
                return null;
            string[] parts = text.Split('_');
            string result = string.Join("", parts.Select(p => char.ToUpper(p[0]) + p.Substring(1)));
            return result;
        }


        public async Task OnGetAsync()
        {
            AppCarmakers = await _context.AppCarmakers.ToListAsync();
            AppEcuTypes = await _context.AppEcuTypes.ToListAsync();
            AppEcuProducers = await _context.AppEcuProducers.ToListAsync();

            IQueryable<AppEcu> ecuQuery = _context.AppEcus.AsQueryable();

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

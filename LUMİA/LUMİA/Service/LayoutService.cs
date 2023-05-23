using LUMİA.DAL;

namespace LUMİA.Service
{
    public class LayoutService
    {
        private readonly AppDbContext _context;
        public LayoutService(AppDbContext context)
        {
            _context = context;
        }
        public Dictionary<string, string> GetLayouts()
        {
            return _context.Settings.ToList().ToDictionary(x=>x.Key , x=>x.Value);
        }
    }
}

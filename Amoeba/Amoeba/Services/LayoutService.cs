using Amoeba.DAL;

namespace Amoeba.Services
{
    public class LayoutService
    {
        private readonly AppDbcontext _context;
        public LayoutService(AppDbcontext context)
        {
            _context = context;
        }
        public Dictionary<string,string> GetLayouts()
        {
            return _context.settings.ToList().ToDictionary(x=>x.Key, x => x.Value);
        }
    }
}

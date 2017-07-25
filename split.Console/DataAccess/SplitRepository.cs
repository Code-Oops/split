using split.Console.Interfaces;

namespace split.Console.DataAccess
{
    public class SplitRepository : ISplitRepository
    {
        private readonly SplitDbContext _context;

        public SplitRepository(SplitDbContext context)
        {
            _context = context;
        }
    }
}

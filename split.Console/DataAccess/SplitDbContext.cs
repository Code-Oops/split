using Microsoft.EntityFrameworkCore;

namespace split.Console.DataAccess
{
    public class SplitDbContext : DbContext
    {
        public SplitDbContext(DbContextOptions options) : base(options) {}
    }
}

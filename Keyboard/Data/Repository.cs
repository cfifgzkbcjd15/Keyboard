using Microsoft.EntityFrameworkCore;

namespace Keyboard.Data
{
    public class Repository
    {
        public DbContextOptions<PurchasesContext> options { get; set; }
        public Repository()
        {
            options = new DbContextOptionsBuilder<PurchasesContext>().UseNpgsql().Options;
        }
    }
}

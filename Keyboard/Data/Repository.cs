using Microsoft.EntityFrameworkCore;

namespace Keyboard.Data
{
    public partial class Repository
    {
        public DbContextOptions<PurchasesContext> options { get; set; }
        public Repository()
        {
            options = new DbContextOptionsBuilder<PurchasesContext>().UseNpgsql().Options;
        }
    }
}

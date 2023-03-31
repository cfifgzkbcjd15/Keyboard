using Keyboard.Models;
using Microsoft.EntityFrameworkCore;

namespace Keyboard.Data
{
    public partial class Repository
    {
        public async Task JsonToBase(Contract contract)
        {
            using (PurchasesContext db = new PurchasesContext(options))
            {
            }
        }
    }
}

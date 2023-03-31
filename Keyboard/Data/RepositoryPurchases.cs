using Keyboard.Models;
using Microsoft.EntityFrameworkCore;

namespace Keyboard.Data
{
    public partial class Repository
    {
        public bool JsonToBase(Contract contract)
        {
            using (PurchasesContext db = new PurchasesContext(options))
            {
                return false;
            }
        }
    }
}

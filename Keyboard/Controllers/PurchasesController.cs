using Keyboard.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Keyboard.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PurchasesController : ControllerBase
    {
        /// <summary>
        /// Вывод с фильтрацией
        /// </summary>
        [HttpPost]
        public async Task<Export> FilterPurchases()
        {
            return null;
        }
    }
}

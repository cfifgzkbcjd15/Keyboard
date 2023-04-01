using Keyboard.Models;
using Microsoft.AspNetCore.Mvc;
using Keyboard.Data;
using Keyboard.Models.OnlyContract;

namespace Keyboard.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContractController : ControllerBase
    {
        private MongoContext db;

        public ContractController(MongoContext _db)
        {
            db = _db;
        }
        //[HttpGet]
        //public async Task<string> Get()
        //{
        //    return await db.GetContract();
        //}
        /// <summary>
        /// Вывод с фильтрацией
        /// </summary>
        [HttpPost("withContract")]
        public async Task<List<Contract>> FilterContract(RequestFilterContract request)
        {
            return await db.GetFilterContract(request);
        }
        /// <summary>
        /// Тестовое добавление
        /// </summary>
        [HttpPost("test")]
        public async Task<string> Post(Contract request)
        {
            var result=await db.CreateContracts(request);
            return result;
        }
    }
}

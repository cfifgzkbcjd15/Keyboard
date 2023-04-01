using Microsoft.AspNetCore.Mvc;
using ConsumerTwo.Models;
using ConsumerTwo.Data;

namespace ConsumerTwo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProcedureController : ControllerBase
    {
        private MongoContext db;

        public ProcedureController(MongoContext _db)
        {
            db = _db;
        }
        [HttpGet]
        public async Task<string> Get()
        {
            return await db.GetContract();
        }
        /// <summary>
        /// Вывод с фильтрацией
        /// </summary>
        /// <summary>
        /// Вывод с фильтрацией процедур
        /// </summary>
        [HttpPost("withContractProcedure")]
        public async Task<List<ContractProcedure>> FilterContractProcedure(RequestFilterContractProcedure request)
        {
            return await db.GetFilterContractProcedure(request);
        }
        /// <summary>
        /// Тестовое добавление
        /// </summary>
        [HttpPost("test")]
        public async Task<string> Post(ContractProcedure request)
        {
            var result=await db.CreateContractsProcedure(request);
            return result;
        }
    }
}

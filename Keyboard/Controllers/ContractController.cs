using Keyboard.Models;
using Microsoft.AspNetCore.Mvc;
using Keyboard.Data;
using Keyboard.Models;

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
        [HttpGet]
        public async Task<string> Get()
        {
            return await db.GetContract();
        }
        [HttpGet("{contractId}")]
        public async Task<ResponseContracts> Get(string contractId)
        {
            return await db.GetContractById(contractId);
        }
        /// <summary>
        /// Вывод с фильтрацией
        /// </summary>
        [HttpPost("withContract")]
        public async Task<List<ResponseContracts>> FilterContract(RequestFilterContract request)
        {
            return await db.GetFilterContract(request);
        }
        //[HttpPost("withContractProcedure")]
        //public async Task<List<ContractProcedure>> FilterContractProcedure(RequestFilterContractProcedure request)
        //{
        //    return await db.GetFilterContractProcedure(request);
        //}
        ///// <summary>
        ///// Тестовое добавление
        ///// </summary>
        //[HttpPost("test")]
        //public async Task<string> Post(ContractProcedure request)
        //{
        //    var result = await db.CreateContractsProcedure(request);
        //    return result;
        //}
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

using Keyboard.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Serialization;
using System;
using System.IO;
using System.Xml;
using System.Runtime.ConstrainedExecution;
using Keyboard.Code;
using Microsoft.AspNetCore.Components.Forms;
using System.Text.Json;
using Keyboard.Data;
using MongoDB.Driver;

namespace Keyboard.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PurchasesController : ControllerBase
    {
        private MongoContext db;

        public PurchasesController(MongoContext _db)
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
        [HttpPost]
        public async Task<List<Contract>> FilterPurchases(RequestFilter request)
        {
            return await db.GetFilterContract(request);
        }
        [HttpPost("test")]
        public async Task<string> Post(Contract request)
        {
            var result=await db.CreateContracts(request);
            return result;
        }
    }
}

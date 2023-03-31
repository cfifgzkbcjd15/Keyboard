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
        public async Task<Contract> FilterPurchases()
        {
            return null;
        }
        [HttpPost("test")]
        public Contract Post(Contract result)
        {
            return result;
        }
    }
}

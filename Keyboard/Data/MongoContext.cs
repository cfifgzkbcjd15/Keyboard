﻿using Keyboard.Models;
using MongoDB.Bson;
using MongoDB.Driver;
using Microsoft.Extensions.Options;
using Keyboard.Code;
using System.Runtime.CompilerServices;
using MongoDB.Driver.Linq;
using System.Diagnostics;
using Keyboard.Models.OnlyContract;

namespace Keyboard.Data
{
    public class MongoContext
    {
        private readonly IMongoDatabase db;
        public MongoContext(IOptions<MongoDBSettings> mongoDBSettings)
        {
            MongoClient client = new MongoClient(mongoDBSettings.Value.ConnectionURI);
            db = client.GetDatabase(mongoDBSettings.Value.DatabaseName);;
        }
        public async Task<string> CreateContracts(Contract request)
        {
            try {
            await db.GetCollection<Contract>("contracts").InsertOneAsync(request);
                return "Success";
            }
            catch(Exception ex)
            {
                Debug.Write(ex.Message);
                return null;
            }
        }
        public async Task<string> GetContract()
        {  // обращаемся к базе данных // получаем коллекцию users
            //await db.DeleteManyAsync(x => x.id != null);
            var contracts = await db.GetCollection<Contract>("contracts").Find("{}").ToListAsync();
            var result = contracts.ToJson();
            return result;
        }
        public async Task<List<Contract>> GetFilterContract(RequestFilterContract request)
        {
            IMongoQueryable<Contract> contracts = db.GetCollection<Contract>("contracts").AsQueryable();
            //var contracts = await db.AsQueryable().ToListAsync();
            if(request.MaxPrice==0)
                request.MaxPrice = int.MaxValue;
            contracts = contracts.Where(x => x.price < request.MaxPrice && x.price > request.MinPrice);
            contracts = contracts.Where(x => x.publishDate > request.StartDate && x.publishDate < request.EndDate);
            if (!string.IsNullOrWhiteSpace(request.FullNameCustomer))
            {
                request.FullNameCustomer = request.FullNameCustomer.ToLower();
                contracts = contracts.Where(x => x.customer.fullName.ToLower().Contains(request.FullNameCustomer));
            }
            if (request.ContractId > 0)
            {
                string contractId = request.ContractId.ToString();
                contracts = contracts.Where(x => x.id == contractId);
            }
            if (!string.IsNullOrWhiteSpace(request.ProductName))
            {
                request.ProductName = request.ProductName.ToLower();
                contracts = contracts.Where(x => x.products.product.Where(x => x.name.ToLower().Contains(request.ProductName)).Any());
            }
            var result = await contracts.Take(10).Skip(20 * request.Page).ToListAsync();
            return result;
        }
    }
}

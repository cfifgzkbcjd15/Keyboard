using MongoDB.Driver;
using Microsoft.Extensions.Options;
using System.Runtime.CompilerServices;
using MongoDB.Driver.Linq;
using System.Diagnostics;
using ConsumerTwo.Code;
using ConsumerTwo.Models.OnlyContractProcedure;
using ConsumerTwo.Models;

namespace ConsumerTwo.Data
{
    public class MongoContext
    {
        private readonly IMongoDatabase db;
        public MongoContext(IOptions<MongoDBSettings> mongoDBSettings)
        {
            MongoClient client = new MongoClient(mongoDBSettings.Value.ConnectionURI);
            db = client.GetDatabase(mongoDBSettings.Value.DatabaseName);;
        }
        public async Task<string> CreateContractsProcedure(ContractProcedure request)
        {
            try
            {
                await db.GetCollection<ContractProcedure>("contractsProcedure").InsertOneAsync(request);
                return "Success";
            }
            catch (Exception ex)
            {
                Debug.Write(ex.Message);
                return null;
            }
        }
        public async Task<List<ContractProcedure>> GetFilterContractProcedure(RequestFilterContractProcedure request)
        {
            IMongoQueryable<ContractProcedure> contracts = db.GetCollection<ContractProcedure>("contractsProcedure").AsQueryable();
            //var contracts = await db.AsQueryable().ToListAsync();
            if (request.MaxPrice == 0)
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

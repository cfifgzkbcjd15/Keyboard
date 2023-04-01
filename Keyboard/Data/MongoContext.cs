using Keyboard.Models;
using MongoDB.Bson;
using MongoDB.Driver;
using Microsoft.Extensions.Options;
using Keyboard.Code;
using MongoDB.Driver.Linq;
using System.Diagnostics;

namespace Keyboard.Data
{
    public class MongoContext
    {
        private readonly IMongoCollection<Contract> db;
        public MongoContext(IOptions<MongoDBSettings> mongoDBSettings)
        {
            MongoClient client = new MongoClient(mongoDBSettings.Value.ConnectionURI);
            IMongoDatabase database = client.GetDatabase(mongoDBSettings.Value.DatabaseName);
            db = database.GetCollection<Contract>(mongoDBSettings.Value.ConnectionName);
        }
        public async Task<string> CreateContracts(Contract request)
        {
            try
            {
                await db.InsertOneAsync(request);
                return "Success";
            }
            catch (Exception ex)
            {
                Debug.Write(ex.Message);
                return null;
            }
        }
        public async Task<string> GetContract()
        {  // обращаемся к базе данных // получаем коллекцию users
            //await db.DeleteManyAsync(x => x.id != null);
            var contracts = await db.Find("{}").ToListAsync();
            var result = contracts.ToJson();
            return result;
        }
        public async Task<ResponseContracts> GetContractById(string id)
        {
            var result=await db.AsQueryable().Where(x=>x.id==id).Select(x => new ResponseContracts
            {
                Id = x.id,
                Href = x.href,
                Price = x.price,
                PublishDate = x.publishDate,
                Customer = x.customer,
                Products = x.products.product
            }).FirstOrDefaultAsync();
            return result;
        }
        public async Task<List<ResponseContracts>> GetFilterContract(RequestFilterContract request)
        {
            IMongoQueryable<Contract> contracts = db.AsQueryable();
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
            if (!string.IsNullOrWhiteSpace(request.ProductName))
            {
                request.ProductName = request.ProductName.ToLower();
                contracts = contracts.Where(x => x.products.product.Where(x => x.name.ToLower().Contains(request.ProductName)).Any());
            }
            var result = await contracts.Skip(20 * request.Page).Take(10)
                .Select(x => new ResponseContracts
                {
                    Id = x.id,
                    Href = x.href,
                    Price=x.price,
                    PublishDate = x.publishDate,
                    Customer = x.customer,
                    Products = x.products.product
                }).ToListAsync();
            return result;
        }
    }
}

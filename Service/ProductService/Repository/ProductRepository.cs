using ProductService.Model;
using ProductService.Settings;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace ProductService.Repository
{
    public interface IProductRepository: IRepository<Product>
    {
    }
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(IOptions<MongoDbSettings> settings) : base(settings)
        {
        }
    }
}

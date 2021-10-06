using Microservice.NET.Core.Model;
using System.Collections.Generic;
namespace Microservice.NET.Core.Repository
{
    public interface IProductRepository
    {
        void DeleteProduct(int productId);
        Product GetProductByID(int productId);
        IEnumerable<Product> GetProducts();
        void InsertProduct(Product product);
        void Save();
        void UpdateProduct(Product product);
    }
}

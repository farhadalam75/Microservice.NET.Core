using Microservice.NET.Core.Model;
using System.Collections.Generic;
namespace Microservice.NET.Core.Repository
{
    internal interface IProductRepository
    {
        void DeleteProduct(int productId);
        Product GetProductByID(int productId);
        IEnumerable<Product> GetProducts();
        void InsertProduct(Product product);
        void Save();
        void UpdateProduct(Product product);
    }
}

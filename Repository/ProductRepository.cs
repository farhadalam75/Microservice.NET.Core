using Microsoft.EntityFrameworkCore;
using Microservice.NET.Core.DBContext;
using Microservice.NET.Core.Model;
using System.Collections.Generic;
using System.Linq;

namespace Microservice.NET.Core.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly ProductContext _dbContext;

        public ProductRepository(ProductContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void DeleteProduct(int productId)
        {
            throw new System.NotImplementedException();
        }

        public Product GetProductByID(int productId)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Product> GetProducts()
        {
            throw new System.NotImplementedException();
        }

        public void InsertProduct(Product product)
        {
            throw new System.NotImplementedException();
        }

        public void Save()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateProduct(Product product)
        {
            throw new System.NotImplementedException();
        }
    }
}  
using Microsoft.EntityFrameworkCore;
using ProductMicroservice.DBContexts;
using ProductMicroservice.Model;
using System;
using System.Collections.Generic;

namespace ProductMicroservice.Repository
{
    public class ProductRepository : IProductRepository
    {
        //public void DeleteProduct(int ProductId)
        //{
        //    throw new NotImplementedException();
        //}
        //public Product GetProduct(int ProductId) 
        //{
        //    throw new NotImplementedException(); 
        //}

        private readonly ProductContext _dbContext;
        public ProductRepository(ProductContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void DeleteProduct(int productId)
        {
            var product = _dbContext.Products.Find(productId);
            _dbContext.Products.Remove(product);
            Save();
        }
        public Product GetProductByID(int productId)
        {
            return _dbContext.Products.Find(productId);
        }
        public IEnumerable<Product> GetProducts()
        {
            return _dbContext.Products.ToList();
        }
        public void InsertProduct(Product product)
        {
            _dbContext.Add(product);
            Save();
        }
        public void UpdateProduct(Product product)
        {
            _dbContext.Entry(product).State = EntityState.Modified;
            Save();
        }
        public void Save()
        {
            _dbContext.SaveChanges();
        }

    }
}

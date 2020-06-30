using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Northwind.DataAccess.Abstract;
using Northwind.Entities.Concrete;

namespace Northwind.DataAccess.Concrete.Oracle
{
    public class OracleProductDal : IProductDal
    {
        public void Add(Product product)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product product)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            List<Product> product = new List<Product> { new Product
            {
                ProductID = 1,
                CategoryID = 1,
                ProductName = "Laptop", 
                QuantityPerUnit = "1 in a box",            //TAMAMEN SALLAMASYON VERİ
                UnitPrice = 3000,
                UnitsInStock = 10
            }};

            return product;
        }

        public Product GetProduct(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}

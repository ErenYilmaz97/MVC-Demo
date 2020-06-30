using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Northwind.DataAccess.Abstract;
using System.Linq.Expressions;

namespace Northwind.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal:IProductDal
    {
        

        public void Add(Product product)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                context.Products.Add(product);
                context.SaveChanges();
            }
        }


        public void Update(Product product)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                
                    //context.Products.Add(product);
                    //context.SaveChanges();
                
            }
        }

        public void Delete(Product product)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                //context.Products.Add(product);
                context.SaveChanges();
            }
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return context.Products.ToList(filter);    //LİST OF PRODUCT ŞEKLİNDE DÖNDÜRÜR.
            }
        }

        public Product GetProduct(Expression<Func<Product, bool>> filter)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return context.Products.SingleOrDefault(filter);
            }
        }
    }
}

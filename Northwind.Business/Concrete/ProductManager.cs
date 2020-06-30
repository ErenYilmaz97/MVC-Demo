using Northwind.DataAccess.Concrete;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Northwind.Business.Abstract;
using Northwind.DataAccess.Abstract;
using Northwind.DataAccess.Concrete.EntityFramework;

namespace Northwind.Business.Concrete
{
   public class ProductManager:IProductService
   {
       private IProductDal _productDal;


       public ProductManager(IProductDal productDal)
       {
           _productDal = productDal;
       }

        public List<Product> GetAll()
        {
            //İŞ KATMANI KODLARININ YAZILDIĞINI DÜŞÜNELİM. DEVAMINDA;

            return _productDal.GetAll();
        }
    }
}

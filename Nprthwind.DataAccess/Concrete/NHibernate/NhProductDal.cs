using Northwind.Entities.Concrete;
using Nprthwind.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Nprthwind.DataAccess.Concrete.NHibernate
{
    public class NhProductDal : IProducDal
    {
        public void Add(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product entity)
        {
            throw new NotImplementedException();
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            List<Product> products = new List<Product> // farklı bir veri tabanıymış gibi bir kod yazıldı. 
            {
                new Product
                {
                    ProductID=1,
                    CategoryID=1,
                    ProductName="Laptop",
                    QuantityPerUnit="1 in a Box",
                    UnitPrice=3000,
                    UnitsInStock=20

                }
            };
            return products;
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}

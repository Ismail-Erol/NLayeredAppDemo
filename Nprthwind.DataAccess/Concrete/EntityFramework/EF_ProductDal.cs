using Northwind.Entities.Concrete;
using Nprthwind.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Nprthwind.DataAccess.Concrete.EntityFramework
{
    public class EF_ProductDal :EF_EntityRepositoryBase<Product,NorthwindContext>, IProducDal
    {
       
    }
}

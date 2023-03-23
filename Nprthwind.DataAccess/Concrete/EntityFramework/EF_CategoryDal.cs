using Northwind.Entities.Concrete;
using Nprthwind.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nprthwind.DataAccess.Concrete.EntityFramework
{
    public class EF_CategoryDal : EF_EntityRepositoryBase<Category, NorthwindContext>, ICategoryDal
    {
    }
}

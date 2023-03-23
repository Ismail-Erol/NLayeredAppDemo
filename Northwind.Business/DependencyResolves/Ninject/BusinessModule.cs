using Ninject.Modules;
using Northwind.Business.Abstract;
using Northwind.Business.Concrete;
using Nprthwind.DataAccess.Abstract;
using Nprthwind.DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Business.DependencyResolves.Ninject
{
    public class BusinessModule:NinjectModule
    {
        public override void Load()
        {
            Bind<IProductService>().To<ProductManager>().InSingletonScope(); // biri senden ıproducservis ister ise ona sen productmanager döndür. 
            Bind<IProducDal>().To<EF_ProductDal>().InSingletonScope();

            Bind<ICategoryService>().To<CategoryManager>().InSingletonScope(); // InSingletonScope() nesneleri tekrardan üretmemek için kullanılan yöntemdir. 
            Bind<ICategoryDal>().To<EF_CategoryDal>().InSingletonScope();
        }
    }
}

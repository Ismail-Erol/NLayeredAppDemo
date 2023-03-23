using FluentValidation;
using Northwind.Business.Abstract;
using Northwind.Business.Utilities;
using Northwind.Business.ValidationRules.FluentValidation;
using Northwind.Entities.Concrete;
using Nprthwind.DataAccess.Abstract;
using Nprthwind.DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Business.Concrete
{
    public class ProductManager : IProductService // iş kodlarının yazıldığı katman olarak nitelendirilir. 
    {
        // EF_ProductDal _producDal = new EF_ProductDal(); bu kod hatalıdır ve bizi bulunduğu yere bağımlı yapar. 
        private IProducDal _producDal;  // Defendens injection methodu

        // burada Iproducdal new edildiğinde bana bir producdal nesnesi ver. 
        // bu entityFramework de olabilir Nhibnernate de olabilir. yada başka bir veri tabanı için oluşturulmuş producdal nesnesi olabilir. 
        public ProductManager(IProducDal producDal) 
        {
            _producDal = producDal;
        }

        public void Add(Product product)
        {
            //ProductValidator productvalidator = new ProductValidator(); // validator tanımlıyoruz. 
            //var result = productvalidator.Validate(product);                         // product ile gelen veriyi doğrulamaya çalışıyoruz. 
            // if (result.Errors.Count > 0)
            // {
            //     throw new ValidationException(result.Errors);
            // }
            ValidationTool.Validate(new ProductValidator(), product);
            _producDal.Add(product); // parametre olarak gönderilen ürünü ekle. 
        }

        public void Delete(Product product)
        {
            try
            {
                _producDal.Delete(product);
            }
            catch (Exception)
            {

                throw new Exception("Silme Gerçekleşemedi.") ;
            }
            
        }

        public List<Product> GetAll()
        {
            
            return _producDal.GetAll();
        }

        public List<Product> GetProductByCategory(int categoryId)
        {
            return _producDal.GetAll(p=>p.CategoryID==categoryId);

        }

        public List<Product> GetProductByProductName(string productName)
        {
            return _producDal.GetAll(p => p.ProductName.ToLower().Contains(productName.ToLower()));
        }

        public void Update(Product product)
        {
            ValidationTool.Validate(new ProductValidator(), product);
            _producDal.Update(product);
        }
    }
}

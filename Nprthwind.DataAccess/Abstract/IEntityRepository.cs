using Northwind.Entities.Abstract;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Nprthwind.DataAccess.Abstract
{
    // bu bölümde her işlemde yapılacak olan operasyonları tek bir koda bağlıyoruz. 
    // örneğin Product için yapılacak işlemler de Categori için yapılacka işlemler de T jenerik ifadesi ile gelecek. 
    // kullanıcıyı da yönlendirmek için jenerik ifadeler kullanabiliriz. 
    // aşağıda where ile başlayan ifadede bir generik sınıf olmalı, Ientity den implemente edilmeli ve newlenebilmeli anlamına gelir 
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null); // kullanıcı değer girerse onu getirir yoksa hepsini getirir. 
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}

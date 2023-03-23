using FluentValidation;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Business.ValidationRules.FluentValidation
{
    public class ProductValidator:AbstractValidator<Product> // doğrulama 
    {
        public ProductValidator()
        {
            RuleFor(p => p.ProductName).NotEmpty().WithMessage("Ürün adı boş olamaz");    // kural içerisinde istersek kendi mesajımızı verebiliriz. 
            RuleFor(p => p.CategoryID).NotEmpty();
            RuleFor(p => p.UnitPrice).NotEmpty();
            RuleFor(p => p.QuantityPerUnit).NotEmpty();
            RuleFor(p=>p.UnitsInStock).NotEmpty();

            RuleFor(p => p.UnitPrice).GreaterThan(0); // unitprice 0 da nküçük olamaz. 
            RuleFor(p => p.UnitsInStock).GreaterThanOrEqualTo((short)0);
            RuleFor(p => p.UnitPrice).GreaterThan(10).When(p => p.CategoryID == 2); // kategori ID si 2 olan ürünler için fiyat 10 dan küçük olamaz. 

            // RuleFor(p => p.ProductName).Must(StartWithA); // metot tanımlanabilir. ürün adı a ile başlamalı gibi


        }

        private bool StartWithA(string arg)
        {
            return arg.StartsWith("A"); 
        }
    }
}

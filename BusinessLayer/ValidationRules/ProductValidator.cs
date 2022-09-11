using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(x => x.ProductName).NotEmpty().WithMessage("Ürün adı boş geçilemez");
            RuleFor(x => x.ProductStock).NotEmpty().WithMessage("Ürün stok boş geçilemez");
            RuleFor(x => x.ProductPrice).NotEmpty().WithMessage("Ürün fiyatı boş geçilemez");
            RuleFor(x => x.ProductImage).NotEmpty().WithMessage("Ürün görseli boş geçilemez");
        }
    }
}

using FluentValidation;
using ProductApp.Web.Models;

namespace ProductApp.Web.Validators
{
    public class ProductDtoValidator : AbstractValidator<ProductDto>
    {
        public ProductDtoValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty().WithMessage("ürüne isim girmek zorunludur.")
                .MinimumLength(3).WithMessage("Ürün ismi en az 3 karakter olmalıdır.");

            RuleFor(x => x.Price)
                .NotEmpty().WithMessage("ürüne fiyat girmek zorunludur.")
                .GreaterThan(0).WithMessage("ürün fiyatı sıfırdan çok olmalıdır.");
        }
    }
}

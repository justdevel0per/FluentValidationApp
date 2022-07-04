using FluentValidation;
using OrnekUygulma.Models;
using System.Text.RegularExpressions;

namespace OrnekUygulma.FluentValidators
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public string NoEmptyMessage { get; } = "{PropertyName} alanı boş olamaz";

        public ProductValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage(NoEmptyMessage);

            RuleFor(x => x.Description).NotEmpty().WithMessage(NoEmptyMessage)
                .MaximumLength(10).WithMessage("Description alana 10 karakterden uzun olamaz");

            RuleFor(x => x.Stock).NotEmpty().WithMessage(NoEmptyMessage)
                .InclusiveBetween(10, 50).WithMessage("Stock değerin en az 10 maksimum 50 adet olmalıdır.");

            RuleFor(x => x.Email).NotEmpty().WithMessage(NoEmptyMessage)
                .EmailAddress().WithMessage("Geçerli bir e-posta adresi giriniz");

            RuleFor(x => x.Password).NotEmpty().WithMessage(NoEmptyMessage)
                .Length(8, 15).WithMessage("Şifre  8-15 karakter arasında  olmalıdır.")
                .Must(x => HasValidPassword(x)).WithMessage("Şifre büyük harf, küçük harf, rakam ve özel karakter içermelidir. ");

            RuleForEach(x => x.Address).SetValidator(new AddressValidator());

              

        }

        private bool HasValidPassword(string pw)
        {
            var lowercase = new Regex("[a-z]+");
            var uppercase = new Regex("[A-Z]+");
            var digit = new Regex("(\\d)+");
            var symbol = new Regex("(\\W)+");
            return (lowercase.IsMatch(pw) && uppercase.IsMatch(pw) && digit.IsMatch(pw) && symbol.IsMatch(pw));
        }


    }





}

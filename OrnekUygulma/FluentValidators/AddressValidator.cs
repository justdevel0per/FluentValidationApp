using FluentValidation;
using OrnekUygulma.Models;

namespace OrnekUygulma.FluentValidators
{
    public class AddressValidator : AbstractValidator<Address>
    {
        public string NoEmptyMessage { get; } = "{PropertyName} alanı boş olamaz";
        public AddressValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage(NoEmptyMessage);

            RuleFor(x => x.Content).NotEmpty().WithMessage(NoEmptyMessage);

            RuleFor(x => x.Province).NotEmpty().WithMessage(NoEmptyMessage);

            RuleFor(x => x.PostCode).NotEmpty().WithMessage(NoEmptyMessage)
            .MaximumLength(5).WithMessage("{PropertyName} alanı {MaxLength} karakterden fazla olamaz."); 
        }
    }
}

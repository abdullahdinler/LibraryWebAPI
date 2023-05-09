using FluentValidation;
using Library.Core.DTOs.AddressDTOs;

namespace Library.Service.Validations
{
    public class AddressDtoValidator : AbstractValidator<AddressDto>
    {
        public AddressDtoValidator()
        {
            RuleFor(x=>x.Addres).NotEmpty().WithMessage("The Address field is required");
        }
    }
}

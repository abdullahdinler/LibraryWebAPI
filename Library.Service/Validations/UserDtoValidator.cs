using FluentValidation;
using Library.Core.DTOs.UserDTOs;

namespace Library.Service.Validations
{
    public class UserDtoValidator : AbstractValidator<UserDto>
    {
        public UserDtoValidator()
        {
            RuleFor(x => x.AddressId).NotEmpty().WithMessage("The Address is field required");
            RuleFor(x => x.FirstName).NotEmpty().WithMessage("The First Name field is required");
            RuleFor(x => x.LastName).NotEmpty().WithMessage("The Last Name field is required");
            RuleFor(x => x.Email).NotEmpty().WithMessage("The Email field is required");
            RuleFor(x => x.Phone).NotEmpty().WithMessage("The Phone number field is required");
            RuleFor(x => x.Status).NotEmpty().WithMessage("The Status field is required");
        }
    }
}

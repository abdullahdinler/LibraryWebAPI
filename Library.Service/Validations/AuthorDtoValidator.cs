using FluentValidation;
using Library.Core.DTOs.AuthorDTOs;

namespace Library.Service.Validations
{
    public class AuthorDtoValidator : AbstractValidator<AuthorDto>
    {
        public AuthorDtoValidator()
        {
            RuleFor(x=>x.FirstName).NotEmpty().WithMessage("The First Name field is required");
            RuleFor(x => x.LastName).NotEmpty().WithMessage("The Last Name field is required");
        }
    }
}

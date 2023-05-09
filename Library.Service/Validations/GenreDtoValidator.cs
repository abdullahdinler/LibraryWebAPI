using FluentValidation;
using Library.Core.DTOs.GenreDTOs;

namespace Library.Service.Validations
{
    public class GenreDtoValidator : AbstractValidator<GenreDto>
    {
        public GenreDtoValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("The Genre is field required");
        }
    }
}

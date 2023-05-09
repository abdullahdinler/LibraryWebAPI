using FluentValidation;
using Library.Core.DTOs.BookDTOs;

namespace Library.Service.Validations
{
    public class BookDtoValidator : AbstractValidator<BookDto>
    {
        public BookDtoValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("The Title field is required");
            RuleFor(x=>x.GenreId).NotEmpty().WithMessage("The Genre field is required");
            RuleFor(x=>x.AuthorId).NotEmpty().WithMessage("The Author field is required");
            RuleFor(x => x.Cover).NotEmpty().WithMessage("The Cover field is required");
            RuleFor(x => x.Status).NotEmpty().WithMessage("The Status field is required");
        }
    }
}

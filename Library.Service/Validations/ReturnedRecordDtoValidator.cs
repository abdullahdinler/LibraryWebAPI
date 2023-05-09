using FluentValidation;
using Library.Core.DTOs.ReturnedRecordDTOs;

namespace Library.Service.Validations
{
    public class ReturnedRecordDtoValidator : AbstractValidator<ReturnedRecordDto>
    {
        public ReturnedRecordDtoValidator()
        {
            RuleFor(x => x.UserId).NotEmpty().WithMessage("The User is field required");
            RuleFor(x => x.BookId).NotEmpty().WithMessage("The Book is field required");
            RuleFor(x => x.Status).NotEmpty().WithMessage("The Status is field required");
            RuleFor(x => x.ReturnDate).NotEmpty().WithMessage("The Return Date is field required");
        }
    }
}

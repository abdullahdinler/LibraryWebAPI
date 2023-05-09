using FluentValidation;
using Library.Core.DTOs.BorrowedRecordDTOs;

namespace Library.Service.Validations
{
    public class BorrowedRecordDtoValidator : AbstractValidator<BorrowedRecordDto>
    {
        public BorrowedRecordDtoValidator()
        {
            RuleFor(x=>x.UserId).NotEmpty().WithMessage("The User field is required");
            RuleFor(x=>x.BookId).NotEmpty().WithMessage("The Book field is required");
            RuleFor(x=>x.Status).NotEmpty().WithMessage("The Status field is required");
            RuleFor(x=>x.BorrowDate).NotEmpty().WithMessage("The Borrowed Date field is required");
            RuleFor(x => x.ReturnDate).NotEmpty().WithMessage("The Return Date is field required");
        }
    }
}

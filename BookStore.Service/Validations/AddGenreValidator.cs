using BookStoreAPI.DTO.Genre.Request;
using FluentValidation;

namespace BookStore.Service.Validations
{
    public class AddGenreValidator : AbstractValidator<AddGenreDto>
    {
        public AddGenreValidator()
        {
            RuleFor(x => x.GenreName).NotNull().WithMessage("GenreName cannot null.").NotEmpty().WithMessage("GenreName cannot empty.");
        }
    }
}

using BookStoreAPI.DTO.Author.Request;
using FluentValidation;

namespace BookStore.Service.Validations
{
    public class AddAuthorValidator : AbstractValidator<AddAuthorDto>
    {
        public AddAuthorValidator()
        {
            RuleFor(x => x.FirstName).NotNull().WithMessage("{propertyName} not null.").NotEmpty().WithMessage("{propertyName} not empty.");
            RuleFor(x => x.LastName).NotNull().WithMessage("{propertyName} not null.").NotEmpty().WithMessage("{propertyName} not empty.");
        }
    }
}

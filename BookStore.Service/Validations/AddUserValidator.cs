using BookStoreAPI.DTO.User.Request;
using FluentValidation;
using System.Text.RegularExpressions;

namespace BookStore.Service.Validations
{
    public class AddUserValidator : AbstractValidator<AddUserDto>
    {
        public AddUserValidator()
        {
            RuleFor(x => x.Username).NotNull()
                .WithMessage("{propertyName} must not null!")
                .NotEmpty().WithMessage("{propertyName} must not empty!")
                .MinimumLength(6).WithMessage("{propertyName} must be greater than or equal to 6 characters.")
                .MaximumLength(15).WithMessage("{propertyName} must be less than or equal to 20 characters.");

            RuleFor(x => x.EmailAdress).EmailAddress().WithMessage("Invalid {propertyName}. Please try again.")
                .NotNull().WithMessage("{propertyName} must not null!")
                .NotEmpty().WithMessage("{propertyName} must not empty!");

            RuleFor(x => x.Password).NotNull()
                .WithMessage("{propertyName} must not null!")
                .NotEmpty().WithMessage("{propertyName} must not empty!")
                .Must(IsPasswordValid).WithMessage("Your password must contain at least eight characters, at least one letter and one number!");
        }
        private bool IsPasswordValid(string arg)
        {
            Regex regex = new(@"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{8,}$");
            return regex.IsMatch(arg);
        }
    }
}

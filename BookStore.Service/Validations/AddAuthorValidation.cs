using BookStore.Core.Entities;
using BookStoreAPI.DTO.Author.Request;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Service.Validations
{
    public class AddAuthorValidation : AbstractValidator<AddAuthorDto>
    {
        public AddAuthorValidation()
        {
            RuleFor(x => x.FirstName).NotNull().WithMessage("{propertyName} not null.").NotEmpty().WithMessage("{propertyName} not empty.");
            RuleFor(x => x.LastName).NotNull().WithMessage("{propertyName} not null.").NotEmpty().WithMessage("{propertyName} not empty.");
        }
    }
}

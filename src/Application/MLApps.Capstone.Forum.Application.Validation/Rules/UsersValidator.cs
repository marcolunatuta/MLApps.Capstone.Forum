using FluentValidation;
using MLApps.Capstone.Forum.Application.Dto;
using MLApps.Capstone.Forum.Application.Dto.Entities;

namespace MLApps.Capstone.Forum.Application.Validation.Rules
{
    public class UsersValidator : AbstractValidator<ResponseApplication<UserDto>>
    {
        public UsersValidator()
        {
            RuleFor(x => x.Data).NotNull();
            RuleFor(x => x.Data!.Username).NotEmpty();
            RuleFor(x => x.Data!.Password).NotEmpty();
        }
    }
}
using MLApps.Capstone.Forum.Application.Dto;
using MLApps.Capstone.Forum.Application.Dto.Entities;

namespace MLApps.Capstone.Forum.Application.Interface.UseCases
{
    public interface IUsersApplication
    {
        Task<ResponseApplication<UserDto>> GetLoginAsync(UserDto request);
    }
}
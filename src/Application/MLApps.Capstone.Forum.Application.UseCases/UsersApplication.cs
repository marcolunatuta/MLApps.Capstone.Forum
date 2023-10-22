using MLApps.Capstone.Forum.Application.Dto;
using MLApps.Capstone.Forum.Application.Dto.Entities;
using MLApps.Capstone.Forum.Application.Interface.UseCases;

namespace MLApps.Capstone.Forum.Application.UseCases
{
    public class UsersApplication : IUsersApplication
    {
        public Task<ResponseApplication<UserDto>> GetLoginAsync(UserDto request)
        {
            throw new NotImplementedException();
        }
    }
}
using MLApps.Capstone.Forum.Domain.Entities;
using MLApps.Capstone.Forum.Transversal.Common;

namespace MLApps.Capstone.Forum.Application.Interface.Repositories
{
    public interface IUsersRepository
    {
        Task<Response<User>> LoginUserAsync(User user);
    }
}
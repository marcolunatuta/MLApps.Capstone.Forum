using MLApps.Capstone.Forum.Application.Interface.Repositories;
using MLApps.Capstone.Forum.Domain.Entities;
using MLApps.Capstone.Forum.Transversal.Common;

namespace MLApps.Capstone.Forum.Persistance.Repositories
{
    public class UsersRepository : IUsersRepository
    {
        public Task<Response<User>> LoginUserAsync(User user)
        {
            throw new NotImplementedException();
        }
    }
}
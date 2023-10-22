using Microsoft.AspNetCore.Mvc;
using MLApps.Capstone.Forum.Application.Dto.Entities;
using MLApps.Capstone.Forum.Application.Interface.UseCases;

namespace MLApps.Capstone.Forum.WebApi.Controllers.v1
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUsersApplication usersApplication;

        public UsersController(IUsersApplication usersApplication)
        {
            this.usersApplication = usersApplication;
        }

        public async Task<IActionResult> LoginAsync(UserDto user)
        {
            var loginResponse = await usersApplication.GetLoginAsync(user);
            return Ok(loginResponse);
        }
    }
}
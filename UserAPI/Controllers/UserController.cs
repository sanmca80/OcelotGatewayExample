using Microsoft.AspNetCore.Mvc;
using UserAPI.Model;
using UserAPI.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UserAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService userService;
        public UserController(IUserService _userService)
        {
            userService = _userService;
        }
        [HttpGet]
        public IEnumerable<User> UserList()
        {
            var userList = userService.GetUserList();
            return userList;
        }
        [HttpGet("{id}")]
        public User GetUserById(int Id)
        {
            return userService.GetUserById(Id);
        }
        [HttpPost]
        public User AddUser(User user)
        {
            return userService.AddUser(user);
        }
        [HttpPut]
        public User UpdateUser(User user)
        {
            return userService.UpdateUser(user);
        }
        [HttpDelete("{id}")]
        public bool DeleteUser(int id)
        {
            return userService.DeleteUser(id);
        }
        
    }
}

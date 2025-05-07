using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyAPI.Models;
using System.Reflection;

namespace MyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        public static List<User> Users = new List<User>();

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(Users);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
            var existedUser = Users.SingleOrDefault(p => p.Id == id);
            if (existedUser == null)
            {
                return NotFound();
            }
            return Ok(existedUser);
        }

        [HttpPost]
        public IActionResult CreateNew(UserModel model)
        {
            //kiểm tra username trùng
            var existedUser = Users.SingleOrDefault(p => p.UserName == model.UserName);
            if (existedUser != null)
            {
                return Ok(new
                {
                    Success = false,
                    Message = $"User {model.UserName} đã tồn tại"
                });
            }
            var user = new User
            {
                Id = Guid.NewGuid(),
                UserName = model.UserName,
                Password = model.Password
            };
            Users.Add(user);
            return Ok(new { Success = true, Data = user });
        }


        [HttpPut("{id}")]
        public IActionResult UpdateById(Guid id, User model)
        {
            if (id != model.Id)
            {
                return Ok(new
                {
                    Success = false,
                    Message = $"{id} không khớp"
                });
            }
            for (int i = 0; i < Users.Count; i++)
            {
                if (Users[i].Id == id)
                {
                    Users[i] = model;
                    break;
                }
            }
            return Ok(model);
        }
    }
}

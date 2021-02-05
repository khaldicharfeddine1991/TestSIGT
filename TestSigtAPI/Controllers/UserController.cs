using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using TestSigtAPI.Models;
using TestSigtAPI.Models.Context;
using TestSigtAPI.Services.Service;

namespace TestSigtAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("{id}")]
        public  ActionResult<User> Get(int id)
        {
            User user =  _userService.GetAll().FirstOrDefault(q => q.Id == id);
            return user;

        }
        [HttpGet]
        public ActionResult<ObservableCollection<User>> Get()
        {
            ObservableCollection<User> users = new ObservableCollection<User>(_userService.GetAll());
            return users;
        }
    }
}

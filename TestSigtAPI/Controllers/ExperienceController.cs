using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using TestSigtAPI.Models;
using TestSigtAPI.Services.Service;

namespace TestSigtAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExperienceController : ControllerBase
    {

        private readonly IExperienceService _experienceService;
        private readonly IUserService _userService;

        public ExperienceController(IExperienceService experienceService, IUserService userService)
        {
            _experienceService = experienceService;
            _userService = userService;

        }
        //Get 
        [HttpGet]
        public ActionResult<ObservableCollection<Experience>> Get()
        {
            ObservableCollection<Experience> experiences = new ObservableCollection<Experience>(_experienceService.GetAll());
            return experiences;

        }
        //Get by Id User
        [HttpGet("{id}")]
        public ActionResult<ICollection<Experience>> Get(int id)
        {
            ObservableCollection<Experience> experiences =new ObservableCollection<Experience>(_experienceService.GetAll().Where(q => q.UserId == id)) ;
            return experiences;

        }
    }
}

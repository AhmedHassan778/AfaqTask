using AutoMapper;
using Domain;
using Domain.Interfaces;
using Domain.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AfaqTask.Controllers
{
    [Authorize]

    [ApiController]
    [Route("[controller]")]
    public class HomeController : Controller
    {


        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;

        public HomeController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }
        [HttpGet]
        public IEnumerable<UserDTO> GetAllUsersWithMoreThan5Certifications()
        {
            var users = unitOfWork.User.Find(user => user.Certifications.Count > 5);
            return users.Select(user => mapper.Map<UserDTO>(user));
        }


        /*[HttpPost("AddUser")]
        public ActionResult AddUser(UserDTO userDto)
        {

            try
            {
                var user = mapper.Map<User>(userDto);
                unitOfWork.User.Add(user);
                if (unitOfWork.Save())
                    return Ok("Successfull");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);

            }
            return BadRequest("failed to add user");
        }*/

    }

}

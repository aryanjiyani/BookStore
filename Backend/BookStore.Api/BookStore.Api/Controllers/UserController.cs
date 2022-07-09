﻿using Microsoft.AspNetCore.Mvc;
using BookStore.Models.Models;
using BookStore.Repository;
using BookStore.Models.ViewModels;
using BookStore.Models.Models;
using System.Linq;

namespace BookStore.Api.Controllers
{
    [ApiController]
    public class UserController : ControllerBase
    {
        UserRepository _repository = new UserRepository();
        [HttpGet] 
        [Route("GetUsers")]
        public IActionResult GetUser()
        {
            return Ok(_repository.GetUsers());
        }

        [HttpPost]
        [Route("Login")]
        public IActionResult Login(LoginModel model)
        {
            User user = _repository.Login(model);
            if (user == null)
                return NotFound();
            return Ok(user);
        }

        [HttpPost]
        [Route("Register")]
        public IActionResult Register(RegisterModel model)
        {
            User user = _repository.Register(model);
            if (user == null)
                return BadRequest();
            return Ok(user);
        }
        [HttpGet]
        [Route("~/api/User/Roles")]
        public IActionResult Roles()
        {
            var roles = _repository.Roles();
            ListResponse<RoleModel> listResponse = new()
            {
                Results = roles.Results.Select(c => new RoleModel(c)),
                TotalRecords = roles.TotalRecords,
            };
            return Ok(listResponse);
        }
    }
}

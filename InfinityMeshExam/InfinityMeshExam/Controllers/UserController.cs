using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InfinityMeshExam.DAL.Repository;
using InfinityMeshExam.DAL.Requests;
using InfinityMeshExam.DAL.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace InfinityMeshExam.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserController : Controller
    {
        private readonly IBaseRepository<UserViewModel, UserUpsertRequest> _userRepository;

        public UserController(IBaseRepository<UserViewModel, UserUpsertRequest> userRepository)
        {
            _userRepository = userRepository;
        }


        [HttpGet]
        public async Task<IActionResult> Get(string search)
        {
            var users = await _userRepository.GetAll(search);
            return Ok(users);
        }
    }
}
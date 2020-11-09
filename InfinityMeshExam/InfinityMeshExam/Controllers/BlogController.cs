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
    public class BlogController : Controller
    {
        private readonly IBaseRepository<BlogViewModel, BlogUpsertRequest> _blogRepository;

        public BlogController(IBaseRepository<BlogViewModel, BlogUpsertRequest> blogRepository)
        {
            _blogRepository = blogRepository;
        }


        [HttpGet]
        public async Task<IActionResult> Get(string search)
        {
            var blogs = await _blogRepository.GetAll(search);
            return Ok(blogs);
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody]BlogUpsertRequest req)
        {

            int id = await _blogRepository.Save(req);
            return Ok(id);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id,[FromBody]BlogUpsertRequest req)
        {

            await _blogRepository.Update(id,req);
            return Ok(id);
        }

    }
}
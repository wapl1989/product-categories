using ApiStore.Business.Filters;
using ApiStore.Business.Interface;
using ApiStore.Business.Models;
using ApiStore.Domain.Entity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiStore.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryBusiness _categoryBusiness;

        public CategoryController(ICategoryBusiness categoryBusiness)
        {
            _categoryBusiness = categoryBusiness;
        }

        // GET: api/<CategoryController>
        [HttpGet]
        public async Task<IEnumerable<Category>> Get()
        {
            return await _categoryBusiness.GetAll();
        }

        [HttpGet("GetWithFilters")]
        public async Task<IEnumerable<Category>> GetWithFilters([FromQuery] CategoryFiltersModel filters)
        {
            var filter = FiltersBusiness.ContainsInCategory(filters);
            return await _categoryBusiness.GetFor(filter);
        }

        // GET api/<CategoryController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CategoryController>
        [HttpPost]
        public IActionResult Post([FromBody] Category value)
        {
            _categoryBusiness.SaveEntity(value);
            return Ok();
        }

        // PUT api/<CategoryController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CategoryController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

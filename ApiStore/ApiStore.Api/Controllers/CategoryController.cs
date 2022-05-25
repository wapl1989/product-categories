using ApiStore.Business.Filters;
using ApiStore.Business.Interface;
using ApiStore.Business.Models;
using ApiStore.Domain.Entity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
        public async Task<IEnumerable<Category>> Get([FromQuery] string size, string page)
        {
            return await _categoryBusiness.GetAll(size,page);
        }

        [HttpGet("GetWithFilters")]
        public async Task<IEnumerable<Category>> GetWithFilters([FromQuery] CategoryFiltersModel filters, string size, string page)
        {
            var filter = FiltersBusiness.ContainsInCategory(filters);
            return await _categoryBusiness.GetFor(filter,size,page);
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
        [HttpPut]
        public IActionResult Put([FromBody] Category value)
        {
            _categoryBusiness.EditEntity(value);
            return Ok();
        }

        // DELETE api/<CategoryController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _categoryBusiness.DeleteEntity(id);
            return Ok();
        }
    }
}

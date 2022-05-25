using ApiStore.Business.Business;
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
    public class ProductController : ControllerBase
    {
        private readonly IProductBusiness _productBusiness;
        public ProductController(IProductBusiness productBusiness)
        {
            _productBusiness = productBusiness;
        }
        // GET: api/<ProductController>
        [HttpGet]
        public async Task<IEnumerable<Product>> Get([FromQuery] string size, string page)
        {            
            return await _productBusiness.GetAll(size,page);
        }
        [HttpGet("GetWithFilters")]
        public async Task<IEnumerable<Product>> GetWithFilters([FromQuery] ProductFiltersModel productsFilters, string size, string page)
        {
            var filter = FiltersBusiness.ContainsInProduct(productsFilters);
            return await _productBusiness.GetFor(filter,size,page);
        }

        // GET api/<ProductController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ProductController>
        [HttpPost]
        public IActionResult Post([FromBody] Product value)
        {
            _productBusiness.SaveEntity(value);
            return Ok();
        }

        // PUT api/<ProductController>/5
        [HttpPut]
        public IActionResult Put([FromBody] Product value)
        {
            _productBusiness.EditEntity(value);
            return Ok();
        }

        // DELETE api/<ProductController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _productBusiness.DeleteEntity(id);
            return Ok();
        }
    }
}

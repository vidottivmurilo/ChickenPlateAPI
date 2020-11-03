using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChickenPlatesApp.Dtos;
using ChickenPlatesApp.Models;
using ChickenPlatesApp.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ChickenPlatesApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SideDishController : ControllerBase
    {
        private readonly ISideDishService _sideDishService;

        public SideDishController(ISideDishService sideDishService)
        {
            _sideDishService = sideDishService;
        }

        // GET: api/<SideDishController>
        [HttpGet("GetAll")]
        public ActionResult<List<SideDish>> GetAll()
        {
            try
            {
                return Ok(_sideDishService.GetAll());
            }
            catch (Exception ex)
            {
                return BadRequest("An error ocurred: " + ex.Message);
            }
            
        }

        // GET api/<SideDishController>/5
        [HttpGet("Get/{id}")]
        public ActionResult<SideDish> Get(long id)
        {
            try
            {
                return Ok(_sideDishService.Get(id));
            }
            catch (Exception ex)
            {
                return BadRequest("An error ocurred: " + ex.Message);
            }
        }

        // POST api/<SideDishController>
        [HttpPost("Create")]
        public ActionResult<SideDish> Create([FromBody] SideDishDto sideDishObject)
        {
            try
            {
                var sideDish = new SideDish { DishName = sideDishObject.DishName };
                var result = _sideDishService.Create(sideDish);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest("An error ocurred: " + ex.Message);
            }
        }

        // PUT api/<SideDishController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<SideDishController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

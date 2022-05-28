using Microsoft.AspNetCore.Mvc;
using CyclingAPI.Data;
using CyclingAPILib;
using CyclingAPILib.Interface;

namespace CyclingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CyclistsController : ControllerBase
    {
        private readonly ICyclistRepo repository;

        public CyclistsController(ICyclistRepo r)
        {
            repository = r;
        }

        [HttpGet]
        public virtual async Task<IActionResult> GetAll()
        {
            return Ok(await repository.GetAll());
        }

        [HttpGet("{id}")]
        public virtual async Task<IActionResult> GetById(int id)
        {
            return Ok(await repository.GetById(id));
        }

        // delete
        [HttpDelete("{id}")]
        public virtual async Task<IActionResult> DeleteById([FromRoute] int id)
        {
            var entity = await repository.DeleteById(id);
            if (entity == null)
            {
                return NotFound(); // 404
            }

            return Ok(entity);
        }

        // create
        [HttpPost]
        public virtual async Task<IActionResult> Add([FromBody] Cyclist entity)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            Cyclist item = await repository.Create(entity);
            if (item == null)
            {
                return NotFound();
            }

            return CreatedAtAction("GetById", new { id = entity.Id }, entity);
        }

        // update
        [HttpPut("{id}")]
        public virtual async Task<IActionResult> Update([FromRoute] int id, [FromBody] Cyclist entity)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != entity.Id)
            {
                return BadRequest();
            }

            Cyclist e = await repository.Update(entity);
            if (e == null)
            {
                return NotFound();
            }
            return Ok(e);
        }
    }
}

using LightCleanArchitecture.Application.Common.Interfaces.Services;
using LightCleanArchitecture.Application.Dtos;
using LightCleanArchitecture.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace LightCleanArchitecture.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoItemController : ControllerBase
    {
        private readonly ITodoItemService _todoItemService;

        public TodoItemController(ITodoItemService todoItemService)
        {
            _todoItemService = todoItemService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<TodoItem>>> GetAllAsync()
        {
            return Ok(await _todoItemService.GetAllAsync());
        }


        [HttpGet("testapi")]
        public ActionResult<TodoItem> TestApi()
        {
            return Ok(new TodoItem { Id = 1, Note = "Test" });
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync(int id)
        {
            var entity = await _todoItemService.GetByIdAsync(id);

            if (entity == null)
            {
                return NotFound();
            }

            return Ok(entity);
        }

        [HttpPost]
        public async Task<IActionResult> AddAsync([FromBody] TodoItemDto entity)
        {
            var addedEntity = await _todoItemService.AddAsync(entity.ToModel());

            return Ok(addedEntity);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAsync(int id, [FromBody] TodoItemDto entity)
        {
            if (id != entity.Id)
            {
                return BadRequest();
            }

            await _todoItemService.UpdateAsync(entity.ToModel());

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            await _todoItemService.DeleteAsync(id);

            return NoContent();
        }

    }
}

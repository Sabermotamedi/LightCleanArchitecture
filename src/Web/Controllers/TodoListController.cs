﻿using LightCleanArchitecture.Application.Common.Interfaces.Services;
using LightCleanArchitecture.Application.Dtos;
using LightCleanArchitecture.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace LightCleanArchitecture.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoListController : ControllerBase
    {
        private readonly ITodoListService _todoListService;

        public TodoListController(ITodoListService todoListService)
        {
            _todoListService = todoListService;
        }

        [HttpGet]
        public async Task<IEnumerable<TodoList>> GetAllAsync()
        {
            return await _todoListService.GetAllAsync();
        }

        [HttpGet(nameof(GetByColorAsync))]
        public async Task<IEnumerable<TodoListDto>> GetByColorAsync([FromQuery]int colorId)
        {
            return await _todoListService.GetByColorAsync(colorId);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync(int id)
        {
            var entity = await _todoListService.GetByIdAsync(id);

            if (entity == null)
            {
                return NotFound();
            }

            return Ok(entity);
        }

        [HttpPost]
        public async Task<IActionResult> AddAsync([FromBody] TodoListDto entity)
        {
            var addedEntity = await _todoListService.AddAsync(entity.ToModel());

            return  Ok(addedEntity);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAsync(int id, [FromBody] TodoListDto entity)
        {
            if (id != entity.Id)
            {
                return BadRequest();
            }

            await _todoListService.UpdateAsync(entity.ToModel());

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            await _todoListService.DeleteAsync(id);

            return NoContent();
        }

    }
}

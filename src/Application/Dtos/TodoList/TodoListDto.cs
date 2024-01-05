using LightCleanArchitecture.Domain.Entities;
using LightCleanArchitecture.Domain.Enums;

namespace LightCleanArchitecture.Application.Dtos
{
    public class TodoListDto
    {
        public int Id { get; set; }

        public string? Title { get; set; }

        public Colour Colour { get; set; } = Colour.White;

        public List<TodoItemDto> Items { get; set; } = new List<TodoItemDto>();

        public DateTimeOffset Created { get; set; }

        public string? CreatedBy { get; set; }

        public DateTimeOffset LastModified { get; set; }

        public string? LastModifiedBy { get; set; }
    }
}

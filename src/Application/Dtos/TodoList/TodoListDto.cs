using LightCleanArchitecture.Domain.Entities;
using LightCleanArchitecture.Domain.Enums;

namespace LightCleanArchitecture.Application.Dtos
{
    public class TodoListDto
    {
        public int Id { get; set; }

        public string? Title { get; set; }

        public Colour Colour { get; set; } = Colour.White;

        public IList<TodoItem> Items { get; private set; } = new List<TodoItem>();

        public DateTimeOffset Created { get; set; }

        public string? CreatedBy { get; set; }

        public DateTimeOffset LastModified { get; set; }

        public string? LastModifiedBy { get; set; }
    }
}

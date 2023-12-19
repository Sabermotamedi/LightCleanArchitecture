using LightCleanArchitecture.Application.Common.Interfaces.Services;
using LightCleanArchitecture.Application.Common.Interfaces;
using LightCleanArchitecture.Domain.Entities;

namespace LightCleanArchitecture.Application.Services
{
    public class TodoItemService : GeneralService<TodoItem>, ITodoItemService
    {
        public TodoItemService(IApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}

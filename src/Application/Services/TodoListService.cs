using LightCleanArchitecture.Application.Common.Interfaces.Services;
using LightCleanArchitecture.Application.Common.Interfaces;
using LightCleanArchitecture.Domain.Entities;

namespace LightCleanArchitecture.Application.Services
{
    public class TodoListService : GeneralService<TodoList>, ITodoListService
    {
        public TodoListService(IApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}

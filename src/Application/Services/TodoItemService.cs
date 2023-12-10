using Application.Common.Interfaces.Services;
using CleanArchitecture.Application.Common.Interfaces;
using Domain.Entities;
using RMgmt.Application.Services;

namespace Application.Services
{
    public class TodoItemService : GeneralService<TodoItem>, ITodoItemService
    {
        public TodoItemService(IApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}

using Application.Common.Interfaces.Services;
using CleanArchitecture.Application.Common.Interfaces;
using Domain.Entities;
using RMgmt.Application.Services;

namespace Application.Services
{
    public class TodoListService : GeneralService<TodoList>, ITodoListService
    {
        public TodoListService(IApplicationDbContext dbContext) : base(dbContext)
        {
        }
    }
}

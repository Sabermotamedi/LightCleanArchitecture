using LightCleanArchitecture.Application.Dtos;
using LightCleanArchitecture.Domain.Entities;

namespace LightCleanArchitecture.Application.Common.Interfaces.Services
{
    public interface ITodoListService : IGeneralService<TodoList>
    {
        Task<IEnumerable<TodoListDto>> GetByColorAsync(int id);
    }
}

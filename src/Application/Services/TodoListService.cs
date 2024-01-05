using LightCleanArchitecture.Application.Common.Interfaces.Services;
using LightCleanArchitecture.Application.Common.Interfaces;
using LightCleanArchitecture.Domain.Entities;
using LightCleanArchitecture.Application.Dtos;


namespace LightCleanArchitecture.Application.Services
{
    public class TodoListService : GeneralService<TodoList>, ITodoListService
    {
        private readonly IApplicationDbContext _dbContext;
        public TodoListService(IApplicationDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<TodoListDto>> GetByColorAsync(int id)
        {
            var todoLists = await _dbContext.TodoLists
                .Where(x => x.Colour == (Domain.Enums.Colour)id)
                .Include(x => x.Items)
                .ToListAsync();

            return todoLists.ToDto();
        }
    }
}

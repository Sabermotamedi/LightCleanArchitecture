namespace LightCleanArchitecture.Application.Common.Interfaces.Services;

public interface IGeneralService<T>
{
    Task<IEnumerable<T>> GetAllAsync();

    Task<T> GetByIdAsync(int id);

    Task<T> AddAsync(T entity);

    Task UpdateAsync(T entity);

    Task DeleteAsync(int id);
}

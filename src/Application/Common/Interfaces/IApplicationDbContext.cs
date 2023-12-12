using Domain.Entities;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace CleanArchitecture.Application.Common.Interfaces;

public interface IApplicationDbContext
{
    DbSet<TodoList> TodoLists { get; }

    DbSet<TodoItem> TodoItems { get; }

    DbSet<T> Set<T>() where T : class;

    EntityEntry<T> Entry<T>(T entity) where T : class;

    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}

using System.Linq.Expressions;
using App.Repositories.Abstractions;

namespace App.Domain.Interfaces;

public interface IRepository<T> : IUnitOfWork where T : class
{
    // Cria uma entidade
    Task<T> AddAsync(T entity);

    // Cria múltiplas entidades
    Task<IEnumerable<T>> AddRangeAsync(IEnumerable<T> entities);

    // Obtém uma entidade por Id
    Task<T> GetByIdAsync(int id);

    // Obtém todas as entidades
    Task<IEnumerable<T>> GetAllAsync();

    // Obtém entidades baseadas em uma condição
    Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> predicate);

    // Remove uma entidade
    Task RemoveAsync(T entity);

    // Remove múltiplas entidades
    Task RemoveRangeAsync(IEnumerable<T> entities);
}

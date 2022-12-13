using IsTakipSistemi.Core.Entities;
using IsTakipSistemi.Core.Return;
using System.Linq.Expressions;

namespace IsTakipSistemi.Core.Repository;

public interface IRepositoryBase<T> where T : EntityBase 
{
    Task<AppReturn<T>> GetAsync(Expression<Func<T, bool>> predicate);
    Task<AppReturn<T>> FindAsync(string id);
    Task<AppReturn<T>> GetAllAsync();

    Task<AppReturn<T>> AddAsync(T entity);
    Task<AppReturn<T>> UpdateAsync(T entity);
    Task<AppReturn<T>> DeleteAsync(string id);
}

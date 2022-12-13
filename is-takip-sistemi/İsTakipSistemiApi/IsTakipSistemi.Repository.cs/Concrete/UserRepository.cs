using IsTakipSistemi.Core.DbContext;
using IsTakipSistemi.Core.Enums;
using IsTakipSistemi.Core.Repository;
using IsTakipSistemi.Core.Return;
using IsTakipSistemi.Entities.Models;
using MongoDB.Driver;
using System.Linq.Expressions;

namespace IsTakipSistemi.Repository.Concrete;

public class UserRepository : IRepositoryBase<ITS_USER>
{
    private readonly MongoDbContext _context;
    private readonly IMongoCollection<ITS_USER> _collection;

    public UserRepository(MongoDbContext context)
    {
        this._context = context;
        this._collection = this._context.GetCollection<ITS_USER>();
    }

    public async Task<AppReturn<ITS_USER>> FindAsync(string id)
    {
        AppReturn<ITS_USER> Retval = new();

        try
        {
            Retval.Entity = await this._collection.Find(x => x.Id == id).FirstOrDefaultAsync();

            Retval.Retcode = (Retval.Entity != null ? Retcode.Ok : Retcode.NoContent);
        }
        catch (Exception ex)
        {
            Retval.Retcode = Retcode.Error;
            Retval.Errors.Add(ex.Message.ToString());
        }

        return await Task.FromResult(Retval);
    }

    public async Task<AppReturn<ITS_USER>> GetAsync(Expression<Func<ITS_USER, bool>> predicate)
    {
        AppReturn<ITS_USER> Retval = new();

        try
        {
            Retval.EntityList = await this._collection.Find(predicate).ToListAsync();

            Retval.Retcode = (Retval.EntityList != null ? Retcode.Ok : Retcode.NoContent);
        }
        catch (Exception ex)
        {
            Retval.Retcode = Retcode.Error;
            Retval.Errors.Add(ex.Message.ToString());
        }

        return await Task.FromResult(Retval);
    }

    public async Task<AppReturn<ITS_USER>> GetAllAsync()
    {
        AppReturn<ITS_USER> Retval = new();

        try
        {

        }
        catch (Exception ex)
        {
            Retval.Retcode = Retcode.Error;
            Retval.Errors.Add(ex.Message.ToString());
        }

        return await Task.FromResult(Retval);
    }

    public async Task<AppReturn<ITS_USER>> AddAsync(ITS_USER entity)
    {
        AppReturn<ITS_USER> Retval = new();

        try
        {

        }
        catch (Exception ex)
        {
            Retval.Retcode = Retcode.Error;
            Retval.Errors.Add(ex.Message.ToString());
        }

        return await Task.FromResult(Retval);
    }

    public async Task<AppReturn<ITS_USER>> UpdateAsync(ITS_USER entity)
    {
        AppReturn<ITS_USER> Retval = new();

        try
        {

        }
        catch (Exception ex)
        {
            Retval.Retcode = Retcode.Error;
            Retval.Errors.Add(ex.Message.ToString());
        }

        return await Task.FromResult(Retval);
    }

    public async Task<AppReturn<ITS_USER>> DeleteAsync(string id)
    {
        AppReturn<ITS_USER> Retval = new();

        try
        {

        }
        catch (Exception ex)
        {
            Retval.Retcode = Retcode.Error;
            Retval.Errors.Add(ex.Message.ToString());
        }

        return await Task.FromResult(Retval);
    }
}

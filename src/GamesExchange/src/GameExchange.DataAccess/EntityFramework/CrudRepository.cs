using GamesExchange.Model.lib;
using Microsoft.EntityFrameworkCore;

namespace GamesExchange.DataAccess.EntityFramework
{
    public class CrudRepository<T> : ICrudRepository<T> where T : BaseEntity
    {
        protected readonly GamesExchangeDbContext _dbContext;

        public CrudRepository(GamesExchangeDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public async Task Create(T entity)
        {
            _dbContext.Set<T>().Add(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task Delete(long id)
        {
            var entity = await GetById(id);
            await Delete(entity);
        }

        public async Task Delete(T entity)
        {
            _dbContext.Set<T>().Remove(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<T> GetById(long id)
        {
            return await _dbContext.Set<T>()
                .FirstOrDefaultAsync(e => e.Id == id);
        }

        public IQueryable<T> GetAll()
        {
            return _dbContext.Set<T>();
        }

        public async Task Update(T entity)
        {
            _dbContext.Set<T>().Update(entity);
            await _dbContext.SaveChangesAsync();
        }

        protected async Task<PagedResult<T>> GetPaged(IQueryable<T> query, int page, int pageSize)
        {
            var pagedResult = new PagedResult<T>();
            var skip = (page - 1) * pageSize;
            pagedResult.RowCount = query.Count();

            pagedResult.Rows = await query.Skip(skip).Take(pageSize).ToListAsync();

            return pagedResult;
        }
    }
}

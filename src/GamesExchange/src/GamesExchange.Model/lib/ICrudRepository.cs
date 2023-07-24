namespace GamesExchange.Model.lib
{
    public interface ICrudRepository<T> where T : BaseEntity
    {
        Task Create(T entity);
        Task Delete(long id);
        Task<T> GetById(long id);
        IQueryable<T> GetAll();
        Task Update(T entity);
    }
}

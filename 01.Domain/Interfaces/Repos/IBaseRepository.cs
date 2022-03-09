namespace _01.Domain.Interfaces.Repos
{
    public interface IBaseRepository<TEntity,Tkey>
    {
        Task<TEntity> AddAsync(TEntity entity);
        Task Delete(TEntity entity);
        Task CommiteChangesAsync();
        Task<TEntity> UpdateAsync(TEntity entity);
    }
}

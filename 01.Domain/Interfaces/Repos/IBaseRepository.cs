namespace _01.Domain.Interfaces.Repos
{
    public interface IBaseRepository<TEntity,Tkey>
    {
        Task<TEntity> AddAndSaveAsync(TEntity entity);
        Task DeleteAndSaveAsync(TEntity entity);
        Task CommiteChangesAsync();
        Task<TEntity> UpdateAndSaveAsync(TEntity entity);
    }
}

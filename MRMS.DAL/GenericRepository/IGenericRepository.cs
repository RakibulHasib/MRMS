using System.Linq.Expressions;

namespace MRMS.DAL
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        IQueryable<TEntity> GetAll();
        IQueryable<TEntity> Get(Expression<Func<TEntity, bool>> expression);
        TEntity Get(int id);
        void Insert(TEntity entity);
        void Update(TEntity entity);
        void Delete(int id);
        void Delete(TEntity entity);
    }
}

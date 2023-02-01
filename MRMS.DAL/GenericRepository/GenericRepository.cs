using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace MRMS.DAL
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        internal DbContext _context;
        internal DbSet<TEntity> _entity;

        public GenericRepository(DbContext context)
        {
            _context = context;
            _entity = _context.Set<TEntity>();
        }

        public virtual IQueryable<TEntity> GetAll()
        {
            return _entity.AsNoTracking();
        }

        public virtual TEntity Get(int id)
        {
            return _entity.Find(id);
        }

        public virtual IQueryable<TEntity> Get(Expression<Func<TEntity, bool>> expression)
        {
            return _entity.Where(expression).AsNoTracking();
        }


        public virtual void Insert(TEntity entity)
        {
            _context.Add(entity);
        }

        public virtual void Update(TEntity entity)
        {
            _context.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }
        public virtual void Delete(int id)
        {
            var deleteEntity = _entity.Find(id);
            _entity.Remove(deleteEntity);
        }

        public virtual void Delete(TEntity entity)
        {
            _entity.Remove(entity);
        }
    }
}

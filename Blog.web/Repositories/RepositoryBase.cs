using Blog.web.Data;
using System.Linq.Expressions;
using Blog.web.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;


namespace Blog.web.Repositories
{
        public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
        {
            protected BlogDbContext _blogDbContext { get; set; }

            public RepositoryBase(BlogDbContext blogDbContext)
            {
                _blogDbContext = blogDbContext;
            }

            public IQueryable<T> FindAll()
            {
                return _blogDbContext.Set<T>().AsNoTracking();
            }

            public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression)
            {
                return _blogDbContext.Set<T>().Where(expression).AsNoTracking();
            }

            public void Create(T entity)
            {
                _blogDbContext.Set<T>().Add(entity);
            }

            public void Update(T entity)
            {
                _blogDbContext.Set<T>().Update(entity);
            }

            public void Delete(T entity)
            {
                _blogDbContext.Set<T>().Remove(entity);
            }
        }
    }



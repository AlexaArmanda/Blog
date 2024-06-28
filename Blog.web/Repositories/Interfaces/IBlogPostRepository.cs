using Blog.web.Data;
using Blog.web.Models.Domain;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
namespace Blog.web.Repositories.Interfaces
{
    //    public interface IBlogPostRepository : IRepositoryBase<BlogPost>

    //    {

    //    }
    //}

    public interface IBlogPostRepository : IRepositoryBase<BlogPost>
    {
        Task<BlogPost> GetBlogPostAsync(int id);
        Task<IEnumerable<BlogPost>> GetAllBlogPostsAsync();
        Task AddBlogPostAsync(BlogPost blogPost);
        Task UpdateBlogPostAsync(BlogPost blogPost);
        Task DeleteBlogPostAsync(int id);
    }

    public class BlogPostRepository : IBlogPostRepository
    {
        private readonly BlogDbContext _context;

        public BlogPostRepository(BlogDbContext context)
        {
            _context = context;
        }

        public async Task<BlogPost> GetBlogPostAsync(int id)
        {
            return await _context.BlogPosts.FindAsync(id);
        }

        public async Task<IEnumerable<BlogPost>> GetAllBlogPostsAsync()
        {
            return await _context.BlogPosts.ToListAsync();
        }

        public async Task AddBlogPostAsync(BlogPost blogPost)
        {
            _context.BlogPosts.Add(blogPost);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateBlogPostAsync(BlogPost blogPost)
        {
            _context.Entry(blogPost).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteBlogPostAsync(int id)
        {
            var blogPost = await _context.BlogPosts.FindAsync(id);
            if (blogPost != null)
            {
                _context.BlogPosts.Remove(blogPost);
                await _context.SaveChangesAsync();
            }
        }

        public IQueryable<BlogPost> FindAll()
        {
            throw new NotImplementedException();
        }

        public IQueryable<BlogPost> FindByCondition(Expression<Func<BlogPost, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public void Create(BlogPost entity)
        {
            throw new NotImplementedException();
        }

        public void Update(BlogPost entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(BlogPost entity)
        {
            throw new NotImplementedException();
        }
    }
}


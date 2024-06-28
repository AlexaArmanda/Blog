using Blog.web.Data;
using Blog.web.Models.Domain;
using Blog.web.Repositories.Interfaces;

namespace Blog.web.Repositories
{
    public class BlogPostRepository : RepositoryBase<BlogPost>, IBlogPostRepository
    {
        public BlogPostRepository(BlogDbContext blogDbContext)
            : base(blogDbContext)
        {
        }

        public Task AddBlogPostAsync(BlogPost blogPost)
        {
            throw new NotImplementedException();
        }

        public Task DeleteBlogPostAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<BlogPost>> GetAllBlogPostsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<BlogPost> GetBlogPostAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateBlogPostAsync(BlogPost blogPost)
        {
            throw new NotImplementedException();
        }
    }
}
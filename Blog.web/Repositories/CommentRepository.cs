using Blog.web.Data;
using Blog.web.Models.Domain;
using Blog.web.Repositories.Interfaces;
namespace Blog.web.Repositories
{
    public class CommentRepository : RepositoryBase<Comment>, ICommentRepository
    {
        public CommentRepository(BlogDbContext blogDbContext)
            : base(blogDbContext)
        {
        }
    }
}
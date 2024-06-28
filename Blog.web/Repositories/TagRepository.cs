using Blog.web.Data;
using Blog.web.Models.Domain;
using Blog.web.Repositories.Interfaces;
namespace Blog.web.Repositories
{
    public class TagRepository : RepositoryBase<Tag>, ITagRepository
    {
        public TagRepository(BlogDbContext blogDbContext)
            : base(blogDbContext)
        {
        }
    }
}
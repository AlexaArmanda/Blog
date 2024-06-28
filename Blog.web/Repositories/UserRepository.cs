using Blog.web.Data;
using Blog.web.Models.Domain;
using Blog.web.Repositories.Interfaces;
using Microsoft.AspNetCore.Identity;
namespace Blog.web.Repositories
{
    public class UserRepository : RepositoryBase<IdentityUser>, IUserRepository
    {
        public UserRepository(BlogDbContext blogDbContext)
            : base(blogDbContext)
        {
        }
    }
}
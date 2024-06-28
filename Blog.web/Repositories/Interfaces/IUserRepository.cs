using Blog.web.Models.Domain;
using Microsoft.AspNetCore.Identity;
namespace Blog.web.Repositories.Interfaces
{
    public interface IUserRepository : IRepositoryBase<IdentityUser>

    {
    }
}
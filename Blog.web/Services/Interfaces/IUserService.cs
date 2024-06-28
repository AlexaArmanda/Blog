using System.Collections.Generic;
using Blog.web.Models;
using Blog.web.Models.Domain;
using Microsoft.AspNetCore.Identity;

namespace Blog.web.Services.Interfaces
{
    public interface IUserService
    {
        void CreateUser(IdentityUser user);
        void DeleteUser(IdentityUser user);

        void UpdateUser(IdentityUser user);
        List<IdentityUser> GetUsers();

        IdentityUser GetUserById(string id);
    }
}

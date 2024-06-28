using System.Collections.Generic;
using Blog.web.Models;
using Blog.web.Models.Domain;

namespace Blog.web.Services.Interfaces
{
    public interface IBlogPostService
    {
        void CreateBlogPost(BlogPost blogPost);
        void DeleteBlogPost(BlogPost blogPost);

        void UpdateBlogPost(BlogPost blogPost);
        List<BlogPost> GetBlogPosts();

        BlogPost GetBlogPostById(int id);
    }
}

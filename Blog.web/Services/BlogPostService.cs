using Blog.web.Models.Domain;
using Blog.web.Repositories.Interfaces;
using Blog.web.Services.Interfaces;
using System.Collections.Generic;
using Blog.web.Models;



namespace Blog.web.Services
{
        public class BlogPostService : IBlogPostService
        {
            private readonly IRepositoryWrapper _repositoryWrapper;

            public BlogPostService(IRepositoryWrapper repositoryWrapper)
            {
                _repositoryWrapper = repositoryWrapper;
            }

            public void CreateBlogPost(BlogPost blogPost)
            {
                _repositoryWrapper.BlogPostRepository.Create(blogPost);
                _repositoryWrapper.Save();
            }

            public void DeleteBlogPost(BlogPost blogPost)
            {
                _repositoryWrapper.BlogPostRepository.Delete(blogPost);
                _repositoryWrapper.Save();
            }

            public void UpdateBlogPost(BlogPost blogPost)
            {
                _repositoryWrapper.BlogPostRepository.Update(blogPost);
                _repositoryWrapper.Save();
            }

            public List<BlogPost> GetBlogPosts()
            {
                return _repositoryWrapper.BlogPostRepository.FindAll().ToList();
            }

            public BlogPost GetBlogPostById(int id)
            {
                return _repositoryWrapper.BlogPostRepository.FindByCondition(c => c.BlogPostId == id).FirstOrDefault()!;
            }

        }
    }



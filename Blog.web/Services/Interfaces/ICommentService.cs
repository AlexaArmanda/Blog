using System.Collections.Generic;
using Blog.web.Models;
using Blog.web.Models.Domain;

namespace Blog.web.Services.Interfaces
{
    public interface ICommentService
    {
        void CreateComment(Comment comment);
        void DeleteComment(Comment comment);

        void UpdateComment(Comment comment);
        List<Comment> GetComments();

        Comment GetCommentById(int id);
    }
}

using Blog.web.Models.Domain;
using Blog.web.Repositories.Interfaces;
using Blog.web.Services.Interfaces;
using System.Collections.Generic;
using Blog.web.Models;



namespace Blog.web.Services
{
    public class CommentService : ICommentService
    {
        private readonly IRepositoryWrapper _repositoryWrapper;

        public CommentService(IRepositoryWrapper repositoryWrapper)
        {
            _repositoryWrapper = repositoryWrapper;
        }

        public void CreateComment(Comment comment)
        {
            _repositoryWrapper.CommentRepository.Create(comment);
            _repositoryWrapper.Save();
        }

        public void DeleteComment(Comment comment)
        {
            _repositoryWrapper.CommentRepository.Delete(comment);
            _repositoryWrapper.Save();
        }

        public void UpdateComment(Comment comment)
        {
            _repositoryWrapper.CommentRepository.Update(comment);
            _repositoryWrapper.Save();
        }

        public List<Comment> GetComments()
        {
            return _repositoryWrapper.CommentRepository.FindAll().ToList();
        }

        public Comment GetCommentById(int id)
        {
            return _repositoryWrapper.CommentRepository.FindByCondition(c => c.CommentId == id).FirstOrDefault()!;
        }

    }
}

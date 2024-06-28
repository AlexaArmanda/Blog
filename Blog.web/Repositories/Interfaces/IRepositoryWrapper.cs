using Blog.web.Repositories.Interfaces;

namespace Blog.web.Repositories.Interfaces
{
    public interface IRepositoryWrapper
    {
        IBlogPostRepository BlogPostRepository { get; }
        ICommentRepository CommentRepository { get; }
        ITagRepository TagRepository { get; }
        IUserRepository UserRepository { get; }

        void Save();
    }
}

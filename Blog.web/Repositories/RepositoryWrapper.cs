using Blog.web.Repositories.Interfaces;
using Blog.web.Repositories;
using Blog.web.Data;


namespace Blog.web.Repositories
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        protected BlogDbContext _blogDbContext { get; set; }
        public RepositoryWrapper(BlogDbContext blogDbContext)
        {
            _blogDbContext = blogDbContext;
        }

        public void Save()
        {
            _blogDbContext.SaveChanges();
        }

        private IBlogPostRepository? _blogPostRepository;
        public IBlogPostRepository BlogPostRepository
        {
            get
            {
                if (_blogPostRepository == null)
                {
                    _blogPostRepository = new BlogPostRepository(_blogDbContext);
                }
                return _blogPostRepository;
            }
        }

        private ICommentRepository? _commentRepository;
        public ICommentRepository CommentRepository
        {
            get
            {
                if (_commentRepository == null)
                {
                    _commentRepository = new CommentRepository(_blogDbContext);
                }
                return _commentRepository;
            }
        }

        private ITagRepository? _tagRepository;
        public ITagRepository TagRepository
        {
            get
            {
                if (_tagRepository == null)
                {
                    _tagRepository = new TagRepository(_blogDbContext);
                }
                return _tagRepository;
            }
        }

      
        private IUserRepository? _userRepository;
        public IUserRepository UserRepository
        {
            get
            {
                if (_userRepository == null)
                {
                    _userRepository = new UserRepository(_blogDbContext);
                }
                return _userRepository;
            }
        }
    }
}


using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blog.web.Models.Domain
{
    public class Comment
    {

        public int? CommentId { get; set; }
        public string? Content { get; set; }
        public string? UserId { get; set; }

        public IdentityUser? User { get; set; }
        public int? BlogPostId { get; set; }
        [ForeignKey(nameof(BlogPostId))]

        public BlogPost? BlogPost { get; set; }

 



    }
}

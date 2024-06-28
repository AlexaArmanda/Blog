using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blog.web.Models.Domain
{
    public class BlogPost
    {
        public int BlogPostId { get; set; }
        public string? Heading { get; set; } 

        public string? PageTitle { get; set; } 

        public string? Content { get; set; } 

        public string? ShortDescription { get; set; } 
        public string? FeaturedImageUrl { get; set; } 
        public string? UrlHandle { get; set; } 
        public DateTime PublishedDate { get; set; }

        public string? Author { get; set; }

        public bool Visible { get; set; }
        public ICollection<Tag>? Tags { get; set; }
        public ICollection<Comment>? Comments { get; set; }
 
        public string? UserId { get; set; }
        [ForeignKey("UserId")]
        public IdentityUser? User { get; set; }

    }
}

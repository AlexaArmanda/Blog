using System.Collections.Generic;
using Blog.web.Models;
using Blog.web.Models.Domain;

namespace Blog.web.Services.Interfaces
{
    public interface ITagService
    {
        void CreateTag(Tag tag);
        void DeleteTag(Tag tag);

        void UpdateTag(Tag tag);
        List<Tag> GetTags();

        Tag GetTagById(int id);
    }
}

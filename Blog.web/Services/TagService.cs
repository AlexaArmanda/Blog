using Blog.web.Models.Domain;
using Blog.web.Repositories.Interfaces;
using Blog.web.Services.Interfaces;
using System.Collections.Generic;
using Blog.web.Models;



namespace Blog.web.Services
{
    public class TagService : ITagService
    {
        private readonly IRepositoryWrapper _repositoryWrapper;

        public TagService(IRepositoryWrapper repositoryWrapper)
        {
            _repositoryWrapper = repositoryWrapper;
        }

        public void CreateTag(Tag tag)
        {
            _repositoryWrapper.TagRepository.Create(tag);
            _repositoryWrapper.Save();
        }

        public void DeleteTag(Tag tag)
        {
            _repositoryWrapper.TagRepository.Delete(tag);
            _repositoryWrapper.Save();
        }

        public void UpdateTag(Tag tag)
        {
            _repositoryWrapper.TagRepository.Update(tag);
            _repositoryWrapper.Save();
        }

        public List<Tag> GetTags()
        {
            return _repositoryWrapper.TagRepository.FindAll().ToList();
        }

        public Tag GetTagById(int id)
        {
            return _repositoryWrapper.TagRepository.FindByCondition(c => c.TagId == id).FirstOrDefault()!;
        }

    }
}

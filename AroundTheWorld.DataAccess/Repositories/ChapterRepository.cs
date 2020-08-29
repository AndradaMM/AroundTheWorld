using AroundTheWorld.BusinessLogic.Entities;
using AroundTheWorld.BusinessLogic.IRepositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace AroundTheWorld.DataAccess.Repositories
{
    public class ChapterRepository : IChapterRepository
    {
        private readonly AtwDbContext _atwDbContext;

        public ChapterRepository(AtwDbContext atwDbContext)
        {
            _atwDbContext = atwDbContext;
        }

        public void Add(Chapter chapter)
        {
            _atwDbContext.Chapters.Add(chapter);
        }

        public Chapter GetById(int id)
        {
            var chapter = _atwDbContext.Chapters.Include(c => c.Image).FirstOrDefault(c => c.Id == id);
            return chapter;
        }

        public IEnumerable<Chapter> GetAllByDiaryId(int diaryId)
        {
            return _atwDbContext.Chapters.Include(c => c.Image).Where(c => c.DiaryId == diaryId);
        }

        public void Remove(Chapter chapter)
        {
            _atwDbContext.Chapters.Remove(chapter);
        }

        public void SaveChanges()
        {
            _atwDbContext.SaveChanges();
        }
    }
}

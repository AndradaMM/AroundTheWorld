using AroundTheWorld.BusinessLogic.Entities;
using AroundTheWorld.BusinessLogic.IRepositories;
using AroundTheWorld.DataAccess.TypeConfigurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AroundTheWorld.DataAccess.Repositories
{
    public class DiaryRepository : IDiaryRepository
    {
        private readonly AtwDbContext _atwDbContext;

        public DiaryRepository(AtwDbContext atwDbContext)
        {
            _atwDbContext = atwDbContext;
        }
        public void Add(Diary diary)
        {
            _atwDbContext.Diaries.Add(diary);
        }

        public Diary GetById(int id)
        {
            var diary = _atwDbContext.Diaries.Include(d => d.Chapters).Include(d => d.Image)
                .FirstOrDefault(d => d.Id == id);
            return diary;
        }

        public IEnumerable<Diary> GetAllPulbic()
        {
            return _atwDbContext.Diaries
                .Include(d => d.Image)
                .Where(d => d.Chapters.Any(c => c.IsPublic));
        }

        public IEnumerable<Diary> GetAllByUserId(Guid userId)
        {
            return _atwDbContext.Diaries
                .Include(d => d.Image)
                .Where(d => d.UserId == userId);
        }

        public void Remove(Diary diary)
        {
            _atwDbContext.Diaries.Remove(diary);
        }

        public void SaveChanges()
        {
            _atwDbContext.SaveChanges();
        }
    }
}

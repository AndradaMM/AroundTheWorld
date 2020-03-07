using AroundTheWorld.BusinessLogic.Entities;
using AroundTheWorld.BusinessLogic.IRepositories;
using System;
using System.Collections.Generic;
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
            var diary = _atwDbContext.Diaries.Find(id);
            return diary;
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

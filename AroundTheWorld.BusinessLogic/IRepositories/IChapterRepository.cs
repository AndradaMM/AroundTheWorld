using AroundTheWorld.BusinessLogic.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AroundTheWorld.BusinessLogic.IRepositories
{
    public interface IChapterRepository
    {
        public Chapter GetById(int id);
        public void Add(Chapter chapter);
        public void Remove(Chapter chapter);
        public void SaveChanges();
        IEnumerable<Chapter> GetAllByDiaryId(int diaryId);
    }
}

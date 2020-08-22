using AroundTheWorld.BusinessLogic.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace AroundTheWorld.BusinessLogic.IRepositories
{
    public interface IDiaryRepository
    {
        public Diary GetById(int id);
        public void Add(Diary diary);
        public void Remove(Diary diary);
        public void SaveChanges();
        IEnumerable<Diary> GetAllPulbic();
    }
}

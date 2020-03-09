using AroundTheWorld.BusinessLogic.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AroundTheWorld.BusinessLogic.IRepositories
{
    public interface IAtwImageRepository
    {
        public AtwImage GetById(int id);
        public void Add(AtwImage atwImage);
        public void Remove(AtwImage atwImage);
        public void SaveChanges();
    }
}

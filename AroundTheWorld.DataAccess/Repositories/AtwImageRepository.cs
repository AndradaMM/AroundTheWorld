using AroundTheWorld.BusinessLogic.Entities;
using AroundTheWorld.BusinessLogic.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace AroundTheWorld.DataAccess.Repositories
{
    public class AtwImageRepository : IAtwImageRepository
    {
        private readonly AtwDbContext _atwDbContext;

        public AtwImageRepository(AtwDbContext atwDbContext)
        {
            _atwDbContext = atwDbContext;
        }

        public void Add(AtwImage atwImage)
        {
            _atwDbContext.AtwImages.Add(atwImage);
        }

        public AtwImage GetById(int id)
        {
            var atwImage = _atwDbContext.AtwImages.Find(id);
            return atwImage;
        }

        public void Remove(AtwImage atwImage)
        {
            _atwDbContext.AtwImages.Remove(atwImage);
        }

        public void SaveChanges()
        {
            _atwDbContext.SaveChanges();
        }
    }
}

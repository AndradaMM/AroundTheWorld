using AroundTheWorld.BusinessLogic.Entities;
using AroundTheWorld.DataAccess.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace AroundTheWorld.Test
{
    [TestClass]
    public class DiaryRepositoryTest
    {
        [TestMethod]
        public void GetDiary()
        {
            //--Arrange
            Diary expected = new Diary
            {
                Id = 1,
                Name = "Test",
                Location = "TestLocation",

                CreatedOn = new DateTime(2020, 1, 1),

            };

            var dbContextFactory = new AtwDbContextFactory();
            var dbContext = dbContextFactory.CreateDbContext(new string[0]);

            var diaryRepository = new DiaryRepository(dbContext);


            //--Act
            var actual = diaryRepository.GetById(1);

            //--Assert
            Assert.AreEqual(expected.Id, actual.Id);
            Assert.AreEqual(expected.Name, actual.Name);
            Assert.AreEqual(expected.Location, actual.Location);

            Assert.AreEqual(expected.CreatedOn, actual.CreatedOn);

            dbContext.Dispose();

        }

        [TestMethod]
        public void AddDiary()
        {

            //--Arrange
            var random = new Random();
            Diary expected = new Diary
            {
                Id = random.Next(1_000_000, 2_000_000),
                Name = "AddDiary",
                Location = "Location3",

                CreatedOn = new DateTime(2020, 5, 5),

            };

            var dbContextFactory = new AtwDbContextFactory();
            var dbContext = dbContextFactory.CreateDbContext(new string[0]);

            var diaryRepository = new DiaryRepository(dbContext);

            //--Act

            diaryRepository.Add(expected);
            diaryRepository.SaveChanges();
            var actual = diaryRepository.GetById(expected.Id);


            //--Assert

            Assert.AreEqual(expected.Id, actual.Id);
            Assert.AreEqual(expected.Name, actual.Name);
            Assert.AreEqual(expected.Location, actual.Location);

            Assert.AreEqual(expected.CreatedOn, actual.CreatedOn);

            dbContext.Dispose();


        }


        [TestMethod]
        public void RemoveDiary()
        {
            //--Arrange
            var random = new Random();
            Diary expected = new Diary
            {
                Id = random.Next(1_000_000, 2_000_000),
                Name = "DeleteDiary",
                Location = "DeleteLocation",

                CreatedOn = new DateTime(2020, 8, 8),

            };
            var dbContextFactory = new AtwDbContextFactory();
            var dbContext = dbContextFactory.CreateDbContext(new string[0]);

            var diaryRepository = new DiaryRepository(dbContext);

            //--Act
            diaryRepository.Add(expected);
            diaryRepository.SaveChanges();
            diaryRepository.Remove(expected);
            diaryRepository.SaveChanges();
            var actual = diaryRepository.GetById(expected.Id);

            //--Assert
            Assert.IsNull(actual);

            dbContext.Dispose();

        }



    }
}

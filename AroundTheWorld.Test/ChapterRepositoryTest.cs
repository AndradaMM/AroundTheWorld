using AroundTheWorld.BusinessLogic.Entities;
using AroundTheWorld.DataAccess.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AroundTheWorld.Test
{
    [TestClass]
    public class ChapterRepositoryTest
    {
        [TestMethod]
        public void AddChapterTest()
        {
            //-- Arrange
            var random = new Random();
            Chapter expected = new Chapter
            {
                Id = random.Next(1_000_000, 2_000_000),
                DiaryId = 1,
                Name = "TestChapter",
                Location = "Narnia",
                Date = new DateTime(2020, 3, 3),
                Content = "Test Content",
                CreatedOn = new DateTime(2020, 9, 9)


            };

            var dbContextFactory = new AtwDbContextFactory();
            var dbContext = dbContextFactory.CreateDbContext(new string[0]);

            var chapterRepository = new ChapterRepository(dbContext);

            //-- Act
            chapterRepository.Add(expected);
            chapterRepository.SaveChanges();
            var actual = chapterRepository.GetById(expected.Id);



            //--Assert
            Assert.AreEqual(expected.Id, actual.Id);
            Assert.AreEqual(expected.DiaryId, actual.DiaryId);
            Assert.AreEqual(expected.Name, actual.Name);
            Assert.AreEqual(expected.Location, actual.Location);
            Assert.AreEqual(expected.Date, actual.Date);
            Assert.AreEqual(expected.Content, actual.Content);
            Assert.AreEqual(expected.CreatedOn, actual.CreatedOn);

            dbContext.Dispose();

        }

        [TestMethod]
        [ExpectedException(typeof(DbUpdateException))]
        public void Should_Fail_When_AddingAChapterWithNegativeDiaryId()
        {
            var dbContextFactory = new AtwDbContextFactory();
            var dbContext = dbContextFactory.CreateDbContext(new string[0]);

            try
            {
                //-- Arrange
                var random = new Random();
                Chapter expected = new Chapter
                {
                    Id = random.Next(1_000_000, 2_000_000),
                    DiaryId = -1,
                    Name = "TestChapter",
                    Location = "Narnia",
                    Date = new DateTime(2020, 3, 3),
                    Content = "Test Content",
                    CreatedOn = new DateTime(2020, 9, 9)


                };

                

                var chapterRepository = new ChapterRepository(dbContext);

                //-- Act
                chapterRepository.Add(expected);
                chapterRepository.SaveChanges();



            }

            finally
            {
                dbContext.Dispose();
            }


            //--Assert




        }





    }
}
